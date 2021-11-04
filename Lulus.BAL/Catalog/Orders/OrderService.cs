using Lulus.BAL.Catalog.Orders.Interfaces;
using Lulus.Data.EF;
using Lulus.ViewModels.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Orders
{
    public class OrderService: IOrderService
    {
        private readonly LulusDBContext _context;
        public OrderService(LulusDBContext context)
        {
            _context = context;
        }

        public async Task<int> AddProductAsync(AddProductToCartRequest request)
        {
            if (!(await UserIDValid(request.UserID)))
            {
                return 1;
            };
            // Invalid 3: Product line not found
            var line = await _context.ProductLines.Where(x => x.ProductLine_ID == request.ProductLineID).FirstOrDefaultAsync();
            if (line == null) return 3;
            // Invalid 4: Size not found
            var size = await _context.Sizes.Where(x => x.Size_ID == request.SizeID).FirstOrDefaultAsync();
            if (size == null) return 4;
            var quantity = await _context.LineQuantities.Where(x => x.ProductLine_ID == request.ProductLineID && x.Size_ID == request.SizeID).Select(x => x.Quantity).FirstOrDefaultAsync();
            var orderID = await GetCurrentCartIDAsync(request.UserID);
            var checkExist = await _context.OrderDetails.Where(x => x.Order_ID == orderID && x.ProductLine_ID == request.ProductLineID &&x.Size_ID == request.SizeID).FirstOrDefaultAsync();
            if(checkExist != null)
            {
                // Invalid 5: Dont have enough product quantity
                if (checkExist.OrderDetail_Quantity + request.Quantity >= quantity) return 5;
                checkExist.OrderDetail_Quantity += request.Quantity;
                await _context.SaveChangesAsync();
                // Valid 6: Update quantity success
                return 6;
            }
            else
            {
                if (request.Quantity >= quantity) return 5;
                var price = await _context.Products.Where(x => x.Product_ID == line.Product_ID).Select(x => x.Product_SalePrice).FirstOrDefaultAsync();
                _context.OrderDetails.Add(new Data.Entities.OrderDetail()
                {
                    OrderDetail_Quantity = request.Quantity,
                    Order_ID = orderID,
                    ProductLine_ID = request.ProductLineID,
                    Size_ID = request.SizeID,
                    OrderDetail_Total = price * request.Quantity
                });
                await _context.SaveChangesAsync();
                // Valid 7: Add product line success
                return 7;
            }
        }

        public async Task<bool> ChangeQuantityAsync(ChangeQuantityRequest request)
        {
            var detail = await _context.OrderDetails.Where(x => x.OrderDetail_ID == request.OrderDetailID).FirstOrDefaultAsync();
            if (detail == null) return false;
            var remain = await _context.LineQuantities
                .Where(x => x.ProductLine_ID == detail.ProductLine_ID && x.Size_ID == detail.Size_ID)
                .Select(x => x.Quantity)
                .FirstOrDefaultAsync();
            if (request.Quantity >= remain) return false;
            detail.OrderDetail_Quantity = request.Quantity;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CheckoutAsync(int orderID)
        {
            var order = await _context.Orders.Where(x => x.Order_ID == orderID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync();
            if (order == null) return false;
            order.Status = Data.Enums.OrderStatus.New;
            order.Order_Total = await _context.OrderDetails.Where(x => x.Order_ID == orderID).SumAsync(x => x.OrderDetail_Total);
            order.CreatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ClearCartAsync(int orderID)
        {
            var order = await _context.Orders.Where(x => x.Order_ID == orderID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync();
            if (order == null) return false;
            var details = await _context.OrderDetails.Where(x => x.Order_ID == orderID).ToListAsync();
            foreach(var item in details)
            {
                _context.OrderDetails.Remove(item);
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<CurrentCartRespond> GetCheckoutInforAsync(int orderID)
        {
            var order = await _context.Orders.Where(x => x.Order_ID == orderID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync();
            if (order == null) return null;
            order.OrderDetails = await _context.OrderDetails.Where(x => x.Order_ID == order.Order_ID).ToListAsync();
            var respondOrder = new CurrentCartRespond()
            {
                Order_ID = order.Order_ID,
                Order_Total = order.OrderDetails.Sum(x => x.OrderDetail_Total),
                Status = Data.Enums.OrderStatus.Choosing,
                DetailCount = order.OrderDetails.Count,
                OrderDetails = new List<OrderDetailInCart>()
            };
            foreach (var item in order.OrderDetails)
            {
                var line = await _context.ProductLines.Where(x => x.ProductLine_ID == item.ProductLine_ID).Select(x => x.ProductLine_ID).FirstOrDefaultAsync();
                var product = await _context.Products.Where(x => x.Product_ID == line).FirstOrDefaultAsync();
                var image = await _context.ProductImages.Where(x => x.ProductLine_ID == item.ProductLine_ID).Select(x => x.ProductImage_Image).FirstAsync();
                var sizeKey = await _context.Sizes.Where(x => x.Size_ID == item.Size_ID).Select(x => x.Size_Key).FirstAsync();
                respondOrder.OrderDetails.Add(new OrderDetailInCart()
                {
                    OrderDetail_ID = item.OrderDetail_ID,
                    OrderDetail_Quantity = item.OrderDetail_Quantity,
                    Product_Name = product.Product_Name,
                    Product_Image = image,
                    Product_Price = product.Product_Price,
                    Product_SellPrice = product.Product_SalePrice,
                    Status = product.Status,
                    SizeKey = sizeKey,
                    OrderDetail_Total = item.OrderDetail_Quantity * product.Product_SalePrice
                });
            }
            return respondOrder;
        }

        public async Task<CurrentCartRespond> GetCurrentOrderAsync(Guid userID)
        {
            var order = await _context.Orders.Where(x => x.User_ID == userID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync();
            if(order == null)
            {
                var createdOrder = new Data.Entities.Order()
                {
                    CreatedDate = DateTime.Now,
                    Order_Total = 0,
                    User_ID = userID,
                    Status = Data.Enums.OrderStatus.Choosing
                };
                _context.Orders.Add(createdOrder);
                await _context.SaveChangesAsync();
                return new CurrentCartRespond()
                {
                    Order_ID = createdOrder.Order_ID,
                    Order_Total = 0,
                    Status = Data.Enums.OrderStatus.Choosing,
                    DetailCount = 0,
                    OrderDetails = new List<OrderDetailInCart>()
                };
            }
            else
            {
                order.OrderDetails = await _context.OrderDetails.Where(x => x.Order_ID == order.Order_ID).ToListAsync();
                var respondOrder = new CurrentCartRespond()
                {
                    Order_ID = order.Order_ID,
                    Order_Total = order.OrderDetails.Sum(x => x.OrderDetail_Total),
                    Status = Data.Enums.OrderStatus.Choosing,
                    DetailCount = order.OrderDetails.Count,
                    OrderDetails = new List<OrderDetailInCart>()
                };
                foreach(var item in order.OrderDetails)
                {
                    var line = await _context.ProductLines.Where(x => x.ProductLine_ID == item.ProductLine_ID).Select(x => x.ProductLine_ID).FirstOrDefaultAsync();
                    var product = await _context.Products.Where(x => x.Product_ID == line).FirstOrDefaultAsync();
                    var image = await _context.ProductImages.Where(x => x.ProductLine_ID == item.ProductLine_ID).Select(x => x.ProductImage_Image).FirstAsync();
                    var sizeKey = await _context.Sizes.Where(x => x.Size_ID == item.Size_ID).Select(x => x.Size_Key).FirstAsync();
                    respondOrder.OrderDetails.Add(new OrderDetailInCart()
                    {
                        OrderDetail_ID = item.OrderDetail_ID,
                        OrderDetail_Quantity = item.OrderDetail_Quantity,
                        Product_Name = product.Product_Name,
                        Product_Image = image,
                        Product_Price = product.Product_Price,
                        Product_SellPrice = product.Product_SalePrice,
                        Status = product.Status,
                        SizeKey = sizeKey,
                        OrderDetail_Total = item.OrderDetail_Quantity * product.Product_SalePrice
                    });
                }
                return respondOrder;
            }
        }

        public async Task<bool> RemoveProductAsync(int orderDetailID)
        {
            var detail = await _context.OrderDetails.Where(x => x.OrderDetail_ID == orderDetailID).FirstOrDefaultAsync();
            if (detail == null) return false;
            var order = await _context.Orders.Where(x => x.Order_ID == detail.Order_ID).FirstOrDefaultAsync();
            if (order.Status != Data.Enums.OrderStatus.Choosing) return false;
            _context.OrderDetails.Remove(detail);
            await _context.SaveChangesAsync();
            return true;
        }
        private async Task<bool> UserIDValid(Guid userID)
        {
            var user = await _context.Users.Where(x => x.Id == userID).FirstOrDefaultAsync();
            if (user == null) return false;
            return true;
        }
        private async Task<int> GetCurrentCartIDAsync(Guid userID)
        {
            var order = await _context.Orders.Where(x => x.User_ID == userID && x.Status == Data.Enums.OrderStatus.Choosing).FirstOrDefaultAsync();
            if (order == null)
            {
                var createdOrder = new Data.Entities.Order()
                {
                    CreatedDate = DateTime.Now,
                    Order_Total = 0,
                    User_ID = userID,
                    Status = Data.Enums.OrderStatus.Choosing
                };
                _context.Orders.Add(createdOrder);
                await _context.SaveChangesAsync();
                return await _context.Orders.Where(x => x.User_ID == userID && x.Status == Data.Enums.OrderStatus.Choosing).Select(x =>x.Order_ID).FirstOrDefaultAsync();
            }
            return order.Order_ID;
        }

        public async Task<List<OrderRespond>> GetOrders(Guid userID)
        {
            var order = await _context.Orders.Where(x => x.User_ID == userID && x.Status != Data.Enums.OrderStatus.Choosing)
                .Select(x => new OrderRespond()
                {
                    Order_ID = x.Order_ID,
                    Order_Total = x.Order_Total,
                    Status = x.Status,
                    DetailCount = x.OrderDetails.Count,
                    CreateDate = x.CreatedDate
                }).ToListAsync();
            return order;
        }
    }
}

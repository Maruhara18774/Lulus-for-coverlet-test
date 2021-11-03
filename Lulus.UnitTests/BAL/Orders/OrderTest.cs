using Lulus.BAL.Catalog.Orders;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Lulus.Data.Enums;

namespace Lulus.UnitTests.BAL.Orders
{
    public class OrderTest
    {
        [Fact]
        public async Task GetCurrentOrderAsync_Success_NewCart()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            var hasher = new PasswordHasher<User>();
            dbcontext.Users.Add(new User()
            {
                Id = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                Email = "annalee@shop.com",
                NormalizedEmail = "ANNALEE@SHOP.COM",
                UserName = "annalee",
                NormalizedUserName = "ANNALEE",
                PhoneNumber = "012545454541",
                PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                Customer_FirstName = "Anna",
                Customer_LastName = "Lee",
                Customer_Address = "22 St. Wall Street, Brooklyn, American",
                SecurityStamp = "NQLC7NG4A7DTOJ5DETPA35OHKTOZMMYP"
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.GetCurrentOrderAsync(new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"));

            Assert.Equal(1, result.Order_ID);
            Assert.Equal(0, result.Order_Total);
            Assert.Equal(OrderStatus.Choosing, result.Status);
            Assert.Equal(0, result.DetailCount);
            Assert.Empty(result.OrderDetails);
        }
        [Fact]
        public async Task GetCurrentOrderAsync_Success_LoadCurrentCart()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            var hasher = new PasswordHasher<User>();
            dbcontext.Users.Add(new User()
            {
                Id = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                Email = "annalee@shop.com",
                NormalizedEmail = "ANNALEE@SHOP.COM",
                UserName = "annalee",
                NormalizedUserName = "ANNALEE",
                PhoneNumber = "012545454541",
                PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                Customer_FirstName = "Anna",
                Customer_LastName = "Lee",
                Customer_Address = "22 St. Wall Street, Brooklyn, American",
                SecurityStamp = "NQLC7NG4A7DTOJ5DETPA35OHKTOZMMYP"
            });
            dbcontext.Orders.Add(new Order()
            {
                Order_ID = 3,
                CreatedDate = DateTime.Now,
                Order_Total = 0,
                User_ID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                Status = OrderStatus.Choosing,
            });
            dbcontext.Categories.Add(new Category()
            {
                Category_ID = 1,
                Category_Name = "My category"
            });
            dbcontext.SubCategories.Add(new SubCategory()
            {
                SubCategory_ID = 1,
                Category_ID = 1,
                SubCategory_Name = "My subcategory"
            });
            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name = "Sample product",
                Product_Price = 50,
                Product_SalePrice = 50,
                Product_Description = "",
                SubCategory_ID = 1,
                Status = ProductStatus.Stocking
            });
            dbcontext.ProductLines.Add(new ProductLine()
            {
                ProductLine_ID = 1,
                Texture_Name = "Red",
                Texture_Image = "",
                ProductLine_CreatedDate = DateTime.Now,
                ProductLine_UpdatedDate = DateTime.Now,
                Product_ID = 1
            });
            dbcontext.Sizes.Add(new Size()
            {
                Size_ID = 1,
                Size_Key = "XXL",
            });
            dbcontext.OrderDetails.Add(new OrderDetail()
            {
                OrderDetail_ID = 1,
                OrderDetail_Quantity = 2,
                OrderDetail_Total = 100,
                Order_ID = 3,
                ProductLine_ID = 1,
                Size_ID = 1
            });
            dbcontext.ProductImages.Add(new ProductImage()
            {
                ProductImage_ID = 1,
                ProductImage_Image = "",
                ProductLine_ID = 1
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.GetCurrentOrderAsync(new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"));

            Assert.Equal(3, result.Order_ID);
            Assert.Equal(100, result.Order_Total);
            Assert.Equal(OrderStatus.Choosing, result.Status);
            Assert.Equal(1, result.DetailCount);
            Assert.Equal(2, result.OrderDetails[0].OrderDetail_Quantity);
            Assert.Equal(100, result.OrderDetails[0].OrderDetail_Total);
        }
        [Fact]
        public async Task AddProductAsync_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            var hasher = new PasswordHasher<User>();
            dbcontext.Users.Add(new User()
            {
                Id = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                Email = "annalee@shop.com",
                NormalizedEmail = "ANNALEE@SHOP.COM",
                UserName = "annalee",
                NormalizedUserName = "ANNALEE",
                PhoneNumber = "012545454541",
                PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                Customer_FirstName = "Anna",
                Customer_LastName = "Lee",
                Customer_Address = "22 St. Wall Street, Brooklyn, American",
                SecurityStamp = "NQLC7NG4A7DTOJ5DETPA35OHKTOZMMYP"
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.GetCurrentOrderAsync(new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"));

            Assert.Equal(1, result.Order_ID);
            Assert.Equal(0, result.Order_Total);
            Assert.Equal(OrderStatus.Choosing, result.Status);
            Assert.Equal(0, result.DetailCount);
            Assert.Empty(result.OrderDetails);
        }
    }
}

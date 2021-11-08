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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.AddProductAsync(new ViewModels.Order.AddProductToCartRequest()
            {
                UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                ProductLineID = 1,
                Quantity = 2,
                SizeID = 1
            });

            Assert.Equal(7, result);
        }
        [Fact]
        public async Task AddProductAsync_Failed_UserInvalid()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.AddProductAsync(new ViewModels.Order.AddProductToCartRequest()
            {
                UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                ProductLineID = 1,
                Quantity = 2,
                SizeID = 1
            });

            Assert.Equal(1, result);
        }
        [Fact]
        public async Task AddProductAsync_Failed_LineNotFound()
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
            dbcontext.Sizes.Add(new Size()
            {
                Size_ID = 1,
                Size_Key = "XXL",
            });
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.AddProductAsync(new ViewModels.Order.AddProductToCartRequest()
            {
                UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                ProductLineID = 1,
                Quantity = 2,
                SizeID = 1
            });

            Assert.Equal(3, result);
        }
        [Fact]
        public async Task AddProductAsync_Failed_SizeNotFound()
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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.AddProductAsync(new ViewModels.Order.AddProductToCartRequest()
            {
                UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                ProductLineID = 1,
                Quantity = 2,
                SizeID = 1
            });

            Assert.Equal(4, result);
        }
        [Fact]
        public async Task AddProductAsync_Failed_LineExist()
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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
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
            await dbcontext.SaveChangesAsync();

            var service = new OrderService(dbcontext);
            var result = await service.AddProductAsync(new ViewModels.Order.AddProductToCartRequest()
            {
                UserID = new Guid("61AE2038-97F2-45E5-91AE-08D961FA9BE8"),
                ProductLineID = 1,
                Quantity = 2,
                SizeID = 1
            });

            Assert.Equal(6, result);
        }

        [Fact]
        public async Task ChangeQuantityAsync_Failed_DetailNotFound() 
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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();
            var service = new OrderService(dbcontext);
            var result = await service.ChangeQuantityAsync(new ViewModels.Order.ChangeQuantityRequest()
            {
                OrderDetailID =1,
                Quantity =2
            });
            Assert.False(result);

        }
        [Fact]
        public async Task CheckoutAsync_Failed()
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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();
            var service = new OrderService(dbcontext);
            var result = await service.CheckoutAsync(new int());
            Assert.False(result);

        }
        [Fact]
        public async Task ClearCartAsync_Failed()
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
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();
            var service = new OrderService(dbcontext);
            var result = await service.ClearCartAsync(new int());
            Assert.False(result);

        }

       

        
    }
}

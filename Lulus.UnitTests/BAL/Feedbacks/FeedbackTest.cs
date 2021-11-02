using Lulus.BAL.Catalog.Feedbacks;
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

namespace Lulus.UnitTests.BAL.Feedbacks
{
    public class FeedbackTest
    {
        [Fact]
        public async Task CreateFeedback_Success()
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
            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name = "Wondrous Water Lilies Royal Blue Maxi Dress",
                Product_Price = 68,
                Product_SalePrice = 68,
                Product_Description = "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.",
                SubCategory_ID = 1,
                Status = Data.Enums.ProductStatus.Stocking
            });
            await dbcontext.SaveChangesAsync();

            var service = new FeedbackService(dbcontext);

            var result = await service.CreateFeedback(new ViewModels.Feedbacks.CreateFeedbackRequest()
            {
                Star = 5,
                Title = "Nice",
                Content = "I love it",
                UserID = "61AE2038-97F2-45E5-91AE-08D961FA9BE8",
                ProductID = 1
            });

            Assert.True(result);
        }
        [Fact]
        public async Task CreateFeedback_Failed_UserNotFound()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name = "Wondrous Water Lilies Royal Blue Maxi Dress",
                Product_Price = 68,
                Product_SalePrice = 68,
                Product_Description = "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.",
                SubCategory_ID = 1,
                Status = Data.Enums.ProductStatus.Stocking
            });

            var service = new FeedbackService(dbcontext);

            var result = await service.CreateFeedback(new ViewModels.Feedbacks.CreateFeedbackRequest()
            {
                Star = 5,
                Title = "Nice",
                Content = "I love it",
                UserID = "61AE2038-97F2-45E5-91AE-08D961FA9BE8",
                ProductID = 1
            });

            Assert.False(result);
        }
        [Fact]
        public async Task CreateFeedback_Failed_ProductNotFound()
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

            var service = new FeedbackService(dbcontext);

            var result = await service.CreateFeedback(new ViewModels.Feedbacks.CreateFeedbackRequest()
            {
                Star = 5,
                Title = "Nice",
                Content = "I love it",
                UserID = "61AE2038-97F2-45E5-91AE-08D961FA9BE8",
                ProductID = 1
            });

            Assert.False(result);
        }
        [Fact]
        public async Task CreateFeedback_Failed_InvalidStar1()
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
            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name = "Wondrous Water Lilies Royal Blue Maxi Dress",
                Product_Price = 68,
                Product_SalePrice = 68,
                Product_Description = "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.",
                SubCategory_ID = 1,
                Status = Data.Enums.ProductStatus.Stocking
            });
            await dbcontext.SaveChangesAsync();

            var service = new FeedbackService(dbcontext);

            var result = await service.CreateFeedback(new ViewModels.Feedbacks.CreateFeedbackRequest()
            {
                Star = -1,
                Title = "Nice",
                Content = "I love it",
                UserID = "61AE2038-97F2-45E5-91AE-08D961FA9BE8",
                ProductID = 1
            });

            Assert.False(result);
        }
        [Fact]
        public async Task CreateFeedback_Failed_InvalidStar2()
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
            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name = "Wondrous Water Lilies Royal Blue Maxi Dress",
                Product_Price = 68,
                Product_SalePrice = 68,
                Product_Description = "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.",
                SubCategory_ID = 1,
                Status = Data.Enums.ProductStatus.Stocking
            });
            await dbcontext.SaveChangesAsync();

            var service = new FeedbackService(dbcontext);

            var result = await service.CreateFeedback(new ViewModels.Feedbacks.CreateFeedbackRequest()
            {
                Star = 6,
                Title = "Nice",
                Content = "I love it",
                UserID = "61AE2038-97F2-45E5-91AE-08D961FA9BE8",
                ProductID = 1
            });

            Assert.False(result);
        }
        [Fact]
        public async Task CreateFeedback_Failed_EmptyTitle()
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
            dbcontext.Products.Add(new Product()
            {
                Product_ID = 1,
                Product_Name = "Wondrous Water Lilies Royal Blue Maxi Dress",
                Product_Price = 68,
                Product_SalePrice = 68,
                Product_Description = "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.",
                SubCategory_ID = 1,
                Status = Data.Enums.ProductStatus.Stocking
            });
            await dbcontext.SaveChangesAsync();

            var service = new FeedbackService(dbcontext);

            var result = await service.CreateFeedback(new ViewModels.Feedbacks.CreateFeedbackRequest()
            {
                Star = 5,
                Title = "",
                Content = "I love it",
                UserID = "61AE2038-97F2-45E5-91AE-08D961FA9BE8",
                ProductID = 1
            });

            Assert.False(result);
        }
    }
}

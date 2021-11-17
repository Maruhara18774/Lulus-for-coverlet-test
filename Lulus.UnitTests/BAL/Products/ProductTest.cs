using Lulus.BAL.Catalog.Products;
using Lulus.BAL.Catalog.Products.DTOs.Public;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.Data.Enums;
using Lulus.ViewModels.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lulus.UnitTests.BAL.Products
{
    public class ProductTest
    {

        [Fact]
        public async Task GetAllByCateID_Success()
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
            var service = new ProductService(dbcontext);

            var result = await service.GetAllByCateID(new GetProductPagingRequest()
            {
                ID = 1,
                PageIndex = 1,
                PageSize = 2
            });

            Assert.NotEmpty(result);
        }
        [Fact]
        public async Task GetAllBySubCateID_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
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
            var service = new ProductService(dbcontext);

            var result = await service.GetAllBySubCateID(new GetProductPagingRequest()
            {
                ID = 1,
                PageIndex = 1,
                PageSize = 2
            });

            Assert.NotEmpty(result);
        }
        [Fact]
        public async Task GetDetailByID_Success()
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
            var service = new ProductService(dbcontext);

            var result = await service.GetDetailByID(new GetProductDetailRequest()
            {
                ID = 1
            });

            Assert.NotNull(result);
        }
        [Fact]
        public async Task GetDetailByID_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ProductService(dbcontext);

            var result = await service.GetDetailByID(new GetProductDetailRequest()
            {
                ID = 1
            });

            Assert.Null(result);
        }
    }
}

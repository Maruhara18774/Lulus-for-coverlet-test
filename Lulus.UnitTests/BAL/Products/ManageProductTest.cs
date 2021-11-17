using Lulus.BAL.Catalog.Products;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.Data.Enums;
using Lulus.ViewModels.Common;
using Lulus.ViewModels.Products.Manage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lulus.UnitTests.BAL.Products
{
    public class ManageProductTest
    {
        [Fact]
        public async Task Create_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductService(dbcontext);
            var result = await service.Create(new ProductCreateRequest()
            {
                Name = "Test Product",
                Price = 20,
                SalePrice = 19.05,
                Description = "Del dsaf fds sdfs sdfsd",
                SubCategoryID = 1
            });

            Assert.Equal(1, result);
        }
        [Fact]
        public async Task Delete_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
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
            await dbcontext.SaveChangesAsync();
            var service = new ManageProductService(dbcontext);
            var result = await service.Delete(1);

            Assert.Equal(1, result);
        }
        [Fact]
        public async Task Delete_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductService(dbcontext);
            var result = await service.Delete(1);

            Assert.Equal(0, result);
        }
        [Fact]
        public async Task GetAllProduct_Success()
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
            dbcontext.ProductImages.Add(new ProductImage()
            {
                ProductImage_ID = 1,
                ProductImage_Image = "",
                ProductLine_ID = 1
            });
            await dbcontext.SaveChangesAsync();

            var service = new ManageProductService(dbcontext);
            var result = await service.GetAllProduct(new PagingRequestBase() 
            { 
                PageIndex = 1,
                PageSize = 2
            });

            Assert.NotNull(result);
        }
        [Fact]
        public async Task Update_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
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
            await dbcontext.SaveChangesAsync();
            var service = new ManageProductService(dbcontext);
            var result = await service.Update(new ProductUpdateRequest()
            {
                Id = 1,
                Name = "Sample product 2",
                Price = 60,
                SalePrice = 55.8,
                Description = "La dela",
                SubCategoryID = 2,
                Status = ProductStatus.StopBusiness
            });

            Assert.Equal(1, result);
        }
        [Fact]
        public async Task UpdatePrice_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
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
            await dbcontext.SaveChangesAsync();
            var service = new ManageProductService(dbcontext);
            var result = await service.UpdatePrice(new UpdatePriceRequest()
            {
                ProductID = 1,
                OriginalPrice = 60,
                SalePrice = 28.6
            });

            Assert.True(result);
        }
        [Fact]
        public async Task UpdatePrice_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductService(dbcontext);
            var result = await service.UpdatePrice(new UpdatePriceRequest()
            {
                ProductID = 1,
                OriginalPrice = 60,
                SalePrice = 28.6
            });

            Assert.False(result);
        }
    }
}

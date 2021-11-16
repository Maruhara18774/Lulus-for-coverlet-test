using Lulus.BAL.Catalog.ProductLines;
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

namespace Lulus.UnitTests.BAL.ProductLines
{
    public class ManageProductLineTest
    {
        [Fact]
        public async Task AddImage_Upload()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductLineService(dbcontext);
            var result = await service.AddImage(new ViewModels.ProductLines.AddImageRequest()
            {
               ProductLineID = 1,
               ImageUrl = ""
            });;
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task AddQuantity_Upload()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductLineService(dbcontext);
            var result = await service.AddQuantity(new ViewModels.LineQuantity.AddQuantityRequest() 
            {
                ProductLineID =1 ,
                Size_ID = 1,
                Quantity = 2
            });
            Assert.Equal(1, result);
        }
        [Fact]
        public async Task AddQuantity_UpdateQuantity()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();

            var service = new ManageProductLineService(dbcontext);
            var result = await service.AddQuantity(new ViewModels.LineQuantity.AddQuantityRequest()
            {
                ID = 1,
                ProductLineID = 1,
                Size_ID = 1,
                Quantity = 2
            });
            Assert.Equal(1, result);
        }
        [Fact]
        public async Task Create_ProductLine_Success ()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            
            var service = new ManageProductLineService(dbcontext);
            var result = await service.CreateProductLine(new ViewModels.ProductLines.CreateProductLineRequest()
            {
               Texture_Name="",
               Texture_Image= null,
               Product_ID = 1,
               ProductLine_ID=2,
               Texture_ImageUrl= ""
            }); ;
            Assert.Equal(1, result);
            
        }
        [Fact]
        public async Task DeleteImage_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
     
            var service = new ManageProductLineService(dbcontext);
            var result = await service.DeleteImage(new ViewModels.ProductLines.DeleteImageRequest()
            {
                ImageID = 2
            });
            Assert.False(result);

        }
        [Fact]
        public async Task DeleteImage_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            dbcontext.ProductLines.Add(new ProductLine()
            {
                ProductLine_ID = 1,
                Texture_Name = "Red",
                Texture_Image = "",
                ProductLine_CreatedDate = DateTime.Now,
                ProductLine_UpdatedDate = DateTime.Now,
                Product_ID = 1
            });
            dbcontext.ProductImages.Add(new ProductImage()
            {
                ProductImage_ID = 1,
                ProductImage_Image = "",
                ProductLine_ID = 1
            });
            await dbcontext.SaveChangesAsync();
            var service = new ManageProductLineService(dbcontext);
            var result = await service.DeleteImage(new ViewModels.ProductLines.DeleteImageRequest()
            {
                ImageID = 1
            });
            Assert.True(result);

        }
        [Fact]
        public async Task GetAllImage_Success_WithoutData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            var service = new ManageProductLineService(dbcontext);

            var result = await service.GetAllImage(new ViewModels.ProductLines.GetAllImageByIDRequest());

            Assert.Empty(result);
        }

        [Fact]
        public async Task GetAllImage_Success_WithData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            

            var service = new ManageProductLineService(dbcontext);

            var result = await service.GetAllImage(new ViewModels.ProductLines.GetAllImageByIDRequest() 
            {
                ProductLineID=2
            });
            Assert.NotNull(result);
        }

        

        [Fact]
        public async Task GetAllLine_Success_WithID()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
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
                Size_Key = "S"
            });
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();


            var service = new ManageProductLineService(dbcontext);

            var result = await service.GetAllLinesByID(new ViewModels.ProductLines.GetAllLinesByIDRequest()
            {
                ProductID=1
            });
            Assert.NotNull(result);
            Assert.Single(result);
        }

        [Fact]
        public async Task UdateProductLine_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductLineService(dbcontext);
            var result = await service.UpdateProductLine(new ViewModels.ProductLines.CreateProductLineRequest()
            {
                ProductLine_ID = 1,
                Product_ID = 2,
                Texture_ImageUrl = "",
                Texture_Name = ""
            });
            Assert.False(result);
        }
        [Fact]
        public async Task UdateProductLine_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            dbcontext.ProductLines.Add(new ProductLine()
            {
                ProductLine_ID = 1,
                Texture_Name = "Red",
                Texture_Image = "",
                ProductLine_CreatedDate = DateTime.Now,
                ProductLine_UpdatedDate = DateTime.Now,
                Product_ID = 1
            });
            await dbcontext.SaveChangesAsync();

            var service = new ManageProductLineService(dbcontext);
            var result = await service.UpdateProductLine(new ViewModels.ProductLines.CreateProductLineRequest()
            {
                ProductLine_ID = 1,
                Product_ID = 1,
                Texture_ImageUrl = "",
                Texture_Name = ""
            });
            Assert.True(result);
        }
        [Fact]
        public async Task UpdateQuantity_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageProductLineService(dbcontext);
            var result = await service.UpdateQuantity(new ViewModels.LineQuantity.UpdateQuantityRequest()
            {
                LineQuantityID = 2,
                Quantity = 2
            });
            Assert.False(result);
        }
        [Fact]
        public async Task UpdateQuantity_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
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
                Size_Key = "S"
            });
            dbcontext.LineQuantities.Add(new LineQuantity()
            {
                LineQuantity_ID = 1,
                ProductLine_ID = 1,
                Size_ID = 1,
                Quantity = 5
            });
            await dbcontext.SaveChangesAsync();
            var service = new ManageProductLineService(dbcontext);
            var result = await service.UpdateQuantity(new ViewModels.LineQuantity.UpdateQuantityRequest()
            {
                LineQuantityID = 1,
                Quantity = 2
            });
            Assert.True(result);
        }
    }
}

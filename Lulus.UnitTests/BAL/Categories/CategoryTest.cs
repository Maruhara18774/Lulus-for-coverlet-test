using Lulus.BAL.Catalog.Categories;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lulus.UnitTests.BAL.Categories
{
    public class CategoryTest
    {
       
        [Fact]
        public async Task GetAllCategory_Success_WithoutData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            var service = new CategoryService(dbcontext);

            var result = await service.GetAllCategory();

            Assert.Empty(result);
        }

        [Fact]
        public async Task GetAllCategory_Success_WithData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            dbcontext.Categories.Add(new Category()
            {
                Category_ID = 1,
                Category_Name = "Pants"
            });
            await dbcontext.SaveChangesAsync();

            var service = new CategoryService(dbcontext);

            var result = await service.GetAllCategory();

            Assert.Equal(1, result.First().ID);
            Assert.Equal("Pants", result.First().Name);
        }
    }
}

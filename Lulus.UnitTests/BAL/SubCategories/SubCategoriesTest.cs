using Lulus.BAL.Catalog.SubCategories;
using Lulus.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lulus.UnitTests.BAL.SubCategories
{
    public class SubCategoriesTest
    {
        [Fact]
        public async Task GetAllSubCategory_Success_WithoutData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
            var service = new SubCategoryService(dbcontext);

            var result = await service.GetAllSubCategoriesByCategoryID(new ViewModels.SubCategories.GetAllSubCategoriesByCategoryIDRequest());

            Assert.Empty(result);
        }

        [Fact]
        public async Task GetAllCategory_Success_WithData()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

           

            var service = new SubCategoryService(dbcontext);

            var result = await service.GetAllSubCategoriesByCategoryID(new ViewModels.SubCategories.GetAllSubCategoriesByCategoryIDRequest()
            {
                CategoryID = 1

            }) ;
            Assert.NotNull(result);

            
        }
    }
}

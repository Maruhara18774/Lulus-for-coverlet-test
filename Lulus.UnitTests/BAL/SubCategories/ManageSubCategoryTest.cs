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
    public class ManageSubCategoryTest
    {
        [Fact]
        public async Task Create_SubCategory_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageSubcategoryService(dbcontext);
            var result = await service.CreateSubCategory(new ViewModels.SubCategories.CreateSubCategoryRequest()
            {
               CategoryID =1,
               Name=""
            }); 
            Assert.Equal(1, result);
        }

        [Fact]
        public void DeleteSubCategory_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);
           
            var service = new ManageSubcategoryService(dbcontext);
            var result = service.DeleteSubCategory(new int() );
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Edit_SubCategory_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var service = new ManageSubcategoryService(dbcontext);
            var result = await service.EditSubCategory(new ViewModels.SubCategories.EditSubCategoryRequest()
            {
                CategoryID = 1,
                Name = "",
                ID= 1
            });
            Assert.Equal(0, result);
        }
       

        




        }
    }

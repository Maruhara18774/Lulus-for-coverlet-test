using Lulus.BAL.Infrastructures;
using Lulus.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lulus.UnitTests.BAL.Users
{
    public class UserTest
    {
        [Fact]
        public async Task Login_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var userManagerMock = new Mock<IUserManager>();
            var signInMangerMock = new Mock<ISignInManager>();
            var configurationMock = new Mock<IConfiguration>();


        }
    }
}

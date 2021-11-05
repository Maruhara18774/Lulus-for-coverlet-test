using Lulus.BAL.Catalog.Users;
using Lulus.BAL.Infrastructures;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
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

            // Sample data
            var hasher = new PasswordHasher<User>();
            var sampleUser = new User()
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
            };
            dbcontext.Users.Add(sampleUser);
            await dbcontext.SaveChangesAsync();

            var userManagerMock = new Mock<IUserManager>();
            userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>())).Returns(() => Task.FromResult(sampleUser));
            IList<string> roles = new List<string>() { "Customer" };
            userManagerMock.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns(() => Task.FromResult(roles));

            var signInMangerMock = new Mock<ISignInManager>();
            MySignInResult msir = new MySignInResult();
            msir.SetSucceeded();
            SignInResult sir = msir;
            signInMangerMock.Setup(x => x.PasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Returns(() => Task.FromResult(sir));

            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(x => x["Tokens:Key"]).Returns(() => "0123456789ASDQWE");
            configurationMock.Setup(x => x["Tokens:Issuer"]).Returns(() => "https://www.lulus.com/");

            var service = new UserService(userManagerMock.Object,signInMangerMock.Object,configurationMock.Object);
            var request = new LoginRequest()
            {
                Username = sampleUser.UserName,
                Password = "Abcd1234!",
                RememberMe = false
            };
            var result = await service.Login(request);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task Login_Failed_AccountNotFound()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var userManagerMock = new Mock<IUserManager>();
            userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>())).Returns(() => Task.FromResult<User>(null));
            IList<string> roles = new List<string>() { "Customer" };
            userManagerMock.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns(() => Task.FromResult(roles));

            var signInMangerMock = new Mock<ISignInManager>();
            MySignInResult msir = new MySignInResult();
            msir.SetSucceeded();
            SignInResult sir = msir;
            signInMangerMock.Setup(x => x.PasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Returns(() => Task.FromResult(sir));

            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(x => x["Tokens:Key"]).Returns(() => "0123456789ASDQWE");
            configurationMock.Setup(x => x["Tokens:Issuer"]).Returns(() => "https://www.lulus.com/");

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new LoginRequest()
            {
                Username = "annalee@gmail.com",
                Password = "Abcd1234!",
                RememberMe = false
            };
            var result = await service.Login(request);
            Assert.Equal("Wrong username", result);
        }
        [Fact]
        public async Task Login_Failed_WrongPassword()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            var hasher = new PasswordHasher<User>();
            var sampleUser = new User()
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
            };
            dbcontext.Users.Add(sampleUser);
            await dbcontext.SaveChangesAsync();

            var userManagerMock = new Mock<IUserManager>();
            userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>())).Returns(() => Task.FromResult(sampleUser));
            IList<string> roles = new List<string>() { "Customer" };
            userManagerMock.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns(() => Task.FromResult(roles));

            var signInMangerMock = new Mock<ISignInManager>();
            MySignInResult msir = new MySignInResult();
            SignInResult sir = msir;
            signInMangerMock.Setup(x => x.PasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Returns(() => Task.FromResult(sir));

            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(x => x["Tokens:Key"]).Returns(() => "0123456789ASDQWE");
            configurationMock.Setup(x => x["Tokens:Issuer"]).Returns(() => "https://www.lulus.com/");

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new LoginRequest()
            {
                Username = sampleUser.UserName,
                Password = "Abcd1234!1",
                RememberMe = false
            };
            var result = await service.Login(request);
            Assert.Equal("Wrong password", result);
        }
        [Fact]
        public async Task Register_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var userManagerMock = new Mock<IUserManager>();
            MyIdentityResult mir = new MyIdentityResult();
            mir.SetSucceeded();
            IdentityResult ir = mir;
            userManagerMock.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(() => Task.FromResult(ir));

            var signInMangerMock = new Mock<ISignInManager>();

            var configurationMock = new Mock<IConfiguration>();

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new RegisterRequest()
            {
                Username = "annalee@gmail.com",
                Password = "Abcd1234!",
                Email = "annalee@gmail.com",
                FirstName = "Anna",
                LastName = "Lee"
            };
            var result = await service.Register(request);
            Assert.True(result);
        }
        [Fact]
        public async Task Register_Failed()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var userManagerMock = new Mock<IUserManager>();
            MyIdentityResult mir = new MyIdentityResult();
            IdentityResult ir = mir;
            userManagerMock.Setup(x => x.CreateAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(() => Task.FromResult(ir));

            var signInMangerMock = new Mock<ISignInManager>();

            var configurationMock = new Mock<IConfiguration>();

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new RegisterRequest()
            {
                Username = "annalee@gmail.com",
                Password = "Abcd1234!",
                Email = "annalee@gmail.com",
                FirstName = "Anna",
                LastName = "Lee"
            };
            var result = await service.Register(request);
            Assert.False(result);
        }
        [Fact]
        public async Task AdminLogin_Success()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            var hasher = new PasswordHasher<User>();
            var sampleUser = new User()
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
            };
            dbcontext.Users.Add(sampleUser);
            await dbcontext.SaveChangesAsync();

            var userManagerMock = new Mock<IUserManager>();
            userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>())).Returns(() => Task.FromResult(sampleUser));
            IList<string> roles = new List<string>() { "Customer" };
            userManagerMock.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns(() => Task.FromResult(roles));

            var signInMangerMock = new Mock<ISignInManager>();
            MySignInResult msir = new MySignInResult();
            msir.SetSucceeded();
            SignInResult sir = msir;
            signInMangerMock.Setup(x => x.PasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Returns(() => Task.FromResult(sir));

            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(x => x["Tokens:Key"]).Returns(() => "0123456789ASDQWE");
            configurationMock.Setup(x => x["Tokens:Issuer"]).Returns(() => "https://www.lulus.com/");

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new LoginRequest()
            {
                Username = sampleUser.UserName,
                Password = "Abcd1234!",
                RememberMe = false
            };
            var result = await service.AdminLogin(request);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task AdminLogin_Failed_AccountNotFound()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            var userManagerMock = new Mock<IUserManager>();
            userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>())).Returns(() => Task.FromResult<User>(null));
            IList<string> roles = new List<string>() { "Customer" };
            userManagerMock.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns(() => Task.FromResult(roles));

            var signInMangerMock = new Mock<ISignInManager>();
            MySignInResult msir = new MySignInResult();
            msir.SetSucceeded();
            SignInResult sir = msir;
            signInMangerMock.Setup(x => x.PasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Returns(() => Task.FromResult(sir));

            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(x => x["Tokens:Key"]).Returns(() => "0123456789ASDQWE");
            configurationMock.Setup(x => x["Tokens:Issuer"]).Returns(() => "https://www.lulus.com/");

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new LoginRequest()
            {
                Username = "annalee@gmail.com",
                Password = "Abcd1234!",
                RememberMe = false
            };
            var result = await service.AdminLogin(request);
            Assert.Equal("Wrong username", result);
        }
        [Fact]
        public async Task AdminLogin_Failed_WrongPassword()
        {
            var builder = new DbContextOptionsBuilder<LulusDBContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var dbcontext = new LulusDBContext(builder.Options);

            // Sample data
            var hasher = new PasswordHasher<User>();
            var sampleUser = new User()
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
            };
            dbcontext.Users.Add(sampleUser);
            await dbcontext.SaveChangesAsync();

            var userManagerMock = new Mock<IUserManager>();
            userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>())).Returns(() => Task.FromResult(sampleUser));
            IList<string> roles = new List<string>() { "Customer" };
            userManagerMock.Setup(x => x.GetRolesAsync(It.IsAny<User>())).Returns(() => Task.FromResult(roles));

            var signInMangerMock = new Mock<ISignInManager>();
            MySignInResult msir = new MySignInResult();
            SignInResult sir = msir;
            signInMangerMock.Setup(x => x.PasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Returns(() => Task.FromResult(sir));

            var configurationMock = new Mock<IConfiguration>();
            configurationMock.Setup(x => x["Tokens:Key"]).Returns(() => "0123456789ASDQWE");
            configurationMock.Setup(x => x["Tokens:Issuer"]).Returns(() => "https://www.lulus.com/");

            var service = new UserService(userManagerMock.Object, signInMangerMock.Object, configurationMock.Object);
            var request = new LoginRequest()
            {
                Username = sampleUser.UserName,
                Password = "Abcd1234!1",
                RememberMe = false
            };
            var result = await service.AdminLogin(request);
            Assert.Equal("Wrong password", result);
        }
    }
    public class MySignInResult : SignInResult
    {
        public void SetSucceeded()
        {
            this.Succeeded = true;
        }
    }
    public class MyIdentityResult: IdentityResult
    {
        public void SetSucceeded()
        {
            this.Succeeded = true;
        }
    }
}

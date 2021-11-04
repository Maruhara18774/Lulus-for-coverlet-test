using Lulus.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Infrastructures
{
    public class UserManager : IUserManager
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> _userManager;

        public UserManager(Microsoft.AspNetCore.Identity.UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public Task<IdentityResult> CreateAsync(User user, string password)
        {
            return _userManager.CreateAsync(user, password);
        }

        public Task<User> FindByNameAsync(string userName)
        {
            return _userManager.FindByNameAsync(userName);
        }

        public Task<IList<string>> GetRolesAsync(User user)
        {
            return _userManager.GetRolesAsync(user);
        }
    }
}

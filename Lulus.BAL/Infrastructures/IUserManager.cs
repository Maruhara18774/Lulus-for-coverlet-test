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
    public interface IUserManager
    {
        Task<User> FindByNameAsync(string userName);
        Task<IList<string>> GetRolesAsync(User user);
        Task<IdentityResult> CreateAsync(User user, string password);
    }
}

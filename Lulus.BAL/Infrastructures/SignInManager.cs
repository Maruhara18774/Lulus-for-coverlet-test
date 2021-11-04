using Lulus.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Infrastructures
{
    public class SignInManager : ISignInManager
    {
        private readonly Microsoft.AspNetCore.Identity.SignInManager<User> _signInManager;
        public SignInManager(Microsoft.AspNetCore.Identity.SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        public Task<SignInResult> PasswordSignInAsync(User user, string password, bool isPersistent, bool lockoutOnFailure)
        {
            return _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
        }
    }
}

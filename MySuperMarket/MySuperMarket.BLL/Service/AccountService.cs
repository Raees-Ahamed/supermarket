using AutoMapper.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace MySuperMarket.BLL.Service
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<CustomerBO> _signInManager;
        private readonly UserManager<CustomerBO> _userManager;
        private readonly IConfiguration _config;

        public AccountService(SignInManager<CustomerBO> signInManager,
            UserManager<CustomerBO> userManager,
            IConfiguration config)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;
        }

        public async Task<UserBO> Login(UserBO model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username,
                model.Password,
                model.RememberMe,
                false);

            if (result.Succeeded)
            {
                return model;
            }
            else
            {
                throw new Exception("Invalid Username Password");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }
    }
}

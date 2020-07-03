using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eisApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        public UserProfileController(UserManager<ApplicationUser> userManger)
        {
            _userManager = userManger;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.FullName,
                user.Email,
                user.UserName
            };
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        [Route("ForAdmin")]
        public string GetForAdmin()
        {
            return "Web method for admin";
        }

        [HttpGet]
        [Authorize(Roles = "Employee")]
        [Route("ForEmployee")]
        public string GetForEmployee()
        {
            return "Web method for Employee";
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Employee")]
        [Route("ForAdminOrEmployee")]
        public string GetForAdminOrEmployee()
        {
            return "Web method for admin or employee";
        }
    }

}

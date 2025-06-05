using IdentityDemo.Application.Dtos;
using IdentityDemo.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDemo.Infrastructure.Services
{
    public class IdentityUserService // Infrastructure-servicen
(
UserManager<ApplicationUser> userManager, // Hanterar användare
SignInManager<ApplicationUser> signInManager, // Hanterar inlogging
RoleManager<IdentityRole> roleManager // Hanterar roller
) : IIdentityUserService
    {
        public async Task<UserResultDto> CreateUserAsync(UserProfileDto user, string password)
        {
            var result = await userManager.CreateAsync(new ApplicationUser
            {
                UserName = user.Email,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            }, password);
            return new UserResultDto(result.Errors.FirstOrDefault()?.Description);
        }
        //..//
    }
}

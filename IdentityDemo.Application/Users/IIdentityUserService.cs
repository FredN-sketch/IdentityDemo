using IdentityDemo.Application.Dtos;
using IdentityDemo.Application.Users;
//using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Application.Users
{
    public interface IIdentityUserService
    {
        public Task<UserResultDto> CreateUserAsync(UserProfileDto user, string password);
       
    }
}
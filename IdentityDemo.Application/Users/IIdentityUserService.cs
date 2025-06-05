using IdentityDemo.Application.Dtos;
using IdentityDemo.Application.Users;
//using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Application.Users
{
    public interface IIdentityUserService
    {
        Task<UserResultDto> CreateUserAsync(UserProfileDto user, string password);
        Task<UserResultDto> SignInAsync(string email, string password);
        
    }
}
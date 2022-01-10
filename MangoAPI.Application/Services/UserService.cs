using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserEntity> _userManager;

        public UserService(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateAsync(UserEntity user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);

            return result;
        }
    }
}
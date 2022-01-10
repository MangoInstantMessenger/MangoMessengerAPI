using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Services
{
    public class SignInManagerService : ISignInManagerService
    {
        private readonly SignInManager<UserEntity> _signInManager;

        public SignInManagerService(SignInManager<UserEntity> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<SignInResult> CheckPasswordSignInAsync(UserEntity user, string password,
            bool lockoutOnFailure)
        {
            var result = await _signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure);

            return result;
        }

    }
}
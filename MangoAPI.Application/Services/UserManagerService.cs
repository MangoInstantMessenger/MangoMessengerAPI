using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Services;

public class UserManagerService : IUserManagerService
{
    private readonly UserManager<UserEntity> userManager;

    public UserManagerService(UserManager<UserEntity> userManager)
    {
        this.userManager = userManager;
    }

    public async Task<IdentityResult> CreateAsync(UserEntity user, string password)
    {
        var result = await userManager.CreateAsync(user, password);

        return result;
    }

    public async Task<IdentityResult> RemovePasswordAsync(UserEntity user)
    {
        var result = await userManager.RemovePasswordAsync(user);

        return result;
    }

    public async Task<IdentityResult> AddPasswordAsync(UserEntity user, string password)
    {
        var result = await userManager.AddPasswordAsync(user, password);

        return result;
    }

    public async Task<bool> CheckPasswordAsync(UserEntity user, string password)
    {
        var result = await userManager.CheckPasswordAsync(user, password);

        return result;
    }
}

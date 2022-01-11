using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Interfaces
{
    public interface IUserManagerService
    {
        Task<IdentityResult> CreateAsync(UserEntity user, string password);

        Task<IdentityResult> RemovePasswordAsync(UserEntity user);

        Task<IdentityResult> AddPasswordAsync(UserEntity user, string password);

        Task<bool> CheckPasswordAsync(UserEntity user, string password);
    }
}
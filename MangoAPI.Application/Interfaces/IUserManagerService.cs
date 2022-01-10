using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Interfaces
{
    public interface IUserManagerService
    {
        Task<IdentityResult> CreateAsync(UserEntity user, string password);
    }
}
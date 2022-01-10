using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> CreateAsync(UserEntity user, string password);
    }
}
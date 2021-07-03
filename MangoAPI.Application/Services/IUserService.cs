using System.Threading.Tasks;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Services
{
    public interface IUserService
    {
        Task<UserEntity> GetUserByTokenIdAsync(string tokenId);
        Task<UserEntity> GetUserByIdAsync(string userId);
    }
}
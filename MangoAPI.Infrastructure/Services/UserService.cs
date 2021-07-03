using System.Linq;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UserService(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<UserEntity> GetUserByTokenIdAsync(string tokenId)
        {
            var user = await _postgresDbContext
                .Users
                .Include(x => x.RefreshTokens)
                .FirstOrDefaultAsync(userEntity =>
                    userEntity.RefreshTokens.Any(tokenEntity => tokenEntity.Id == tokenId));

            return user;
        }

        public async Task<UserEntity> GetUserByIdAsync(string userId)
        {
            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
            return user;
        }
    }
}
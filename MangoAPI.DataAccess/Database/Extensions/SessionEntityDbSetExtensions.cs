using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class SessionEntityDbSetExtensions
    {
        public static IQueryable<SessionEntity> GetUserSessionsById(this DbSet<SessionEntity> dbSet,
            string userId)
        {
            return dbSet.Where(x => x.UserId == userId);
        }

        public static async Task<SessionEntity> GetUserSessionByRefreshTokenAsync(this DbSet<SessionEntity> dbSet,
            string refreshToken, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken,
                cancellationToken);
        }
    }
}
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class SessionEntityDbSetExtensions
    {
        public static IQueryable<SessionEntity> GetUserSessionsById(this DbSet<SessionEntity> dbSet, Guid userId)
        {
            return dbSet.Where(entity => entity.UserId == userId);
        }

        public static async Task<SessionEntity> GetSessionByRefreshTokenAsync(this DbSet<SessionEntity> dbSet,
            Guid refreshToken, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(entity => entity.RefreshToken == refreshToken, 
                cancellationToken);
        }
    }
}
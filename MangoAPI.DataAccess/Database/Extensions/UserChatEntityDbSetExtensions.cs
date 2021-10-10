using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class UserChatDbSetExtensions
    {
        public static async Task<UserChatEntity> FindUserChatByIdAsync(this DbSet<UserChatEntity> dbSet,
            Guid userId, Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Where(x => x.UserId == userId)
                .FirstOrDefaultAsync(x => x.ChatId == chatId, cancellationToken);
        }

        public static async Task<bool> IsAlreadyJoinedAsync(this DbSet<UserChatEntity> dbSet,
            Guid userId, Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet.AsNoTracking().AnyAsync(x => x.UserId == userId && x.ChatId == chatId, cancellationToken);
        }
    }
}
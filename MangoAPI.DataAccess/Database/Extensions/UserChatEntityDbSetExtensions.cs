using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class UserChatDbSetExtensions
    {
        public static async Task<List<UserChatEntity>> FindUserChatsByIdIncludeMessagesAsync(
            this DbSet<UserChatEntity> dbSet,
            string userId, CancellationToken cancellationToken)
        {
            return await dbSet.AsNoTracking()
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.UserId == userId)
                .ToListAsync(cancellationToken);
        }

        public static async Task<UserChatEntity> FindUserChatByIdAsync(this DbSet<UserChatEntity> dbSet,
            string userId, string chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Where(x => x.UserId == userId)
                .FirstOrDefaultAsync(x => x.ChatId == chatId, cancellationToken);
        }

        public static async Task<bool> IsAlreadyJoinedAsync(this DbSet<UserChatEntity> dbSet,
            string userId, string chatId, CancellationToken cancellationToken)
        {
            return await dbSet.AnyAsync(x => x.UserId == userId && x.ChatId == chatId, cancellationToken);
        }
    }
}
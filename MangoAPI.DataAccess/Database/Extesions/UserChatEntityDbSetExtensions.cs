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
        public static async Task<List<UserChatEntity>> GetUserChatsByIdIncludeMessagesAsync(this DbSet<UserChatEntity> dbSet,
            string userId, CancellationToken cancellationToken)
        {
            return await dbSet.AsNoTracking()
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.UserId == userId)
                .ToListAsync(cancellationToken);
        }

        public static async Task<UserChatEntity> GetUserChatByIdAsync(this DbSet<UserChatEntity> dbSet,
            string userId, string chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Where(x => x.UserId == userId)
                .FirstOrDefaultAsync(x => x.ChatId == chatId, cancellationToken);
        }
        
        
    }
}
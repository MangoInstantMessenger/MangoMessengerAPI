using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class MessageEntityDbSetExtensions
    {
        public static async Task<List<MessageEntity>> GetChatMessagesByIdAsync(this DbSet<MessageEntity> dbSet,
            string chatId, CancellationToken cancellationToken)
        {
            return await dbSet.Where(x => x.ChatId == chatId)
                .ToListAsync(cancellationToken);
        }

        public static IEnumerable<MessageEntity> GetChatMessagesByIdIncludeUser(this DbSet<MessageEntity> dbSet,
            string chatId)
        {
            return dbSet.AsNoTracking()
                .Include(x => x.User)
                .Where(x => x.ChatId == chatId)
                .AsEnumerable();
        }

        public static async Task<MessageEntity> FindMessageByUserIdAsync(this DbSet<MessageEntity> dbSet,
            string messageId, string userId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == messageId && x.UserId == userId, 
                cancellationToken);
        }
    }
}
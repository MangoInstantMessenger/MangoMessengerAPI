using System;
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
            Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet.Where(x => x.ChatId == chatId)
                .ToListAsync(cancellationToken);
        }

        public static async Task<List<MessageEntity>> SearchChatMessagesIncludeUserAsync(
            this DbSet<MessageEntity> dbSet,
            string messageText, Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Include(x => x.User)
                .AsNoTracking()
                .Where(x => x.ChatId == chatId)
                .Where(x => x.Content.Contains(messageText))
                .ToListAsync(cancellationToken);
        }

        public static IEnumerable<MessageEntity> GetChatMessagesByIdIncludeUser(this DbSet<MessageEntity> dbSet,
            Guid chatId)
        {
            return dbSet.AsNoTracking()
                .Include(x => x.User)
                .Where(x => x.ChatId == chatId)
                .AsEnumerable();
        }

        public static async Task<MessageEntity> FindMessageByUserIdAsync(this DbSet<MessageEntity> dbSet,
            Guid messageId, Guid userId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == messageId && x.UserId == userId,
                cancellationToken);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class ChatEntityDbSetExtensions
    {
        public static async Task<List<ChatEntity>> GetUserPrivateChatsAsync(this DbSet<ChatEntity> dbSet,
            string userId, CancellationToken cancellationToken)
        {
            return await dbSet.Include(chatEntity => chatEntity.ChatUsers)
                .Where(chatEntity => chatEntity.ChatType == ChatType.DirectChat && chatEntity.ChatUsers
                    .Any(userChatEntity => userChatEntity.UserId == userId))
                .ToListAsync(cancellationToken);
        }

        public static async Task<ChatEntity> FindChatByIdAsync(this DbSet<ChatEntity> dbSet,
            string chatId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == chatId, cancellationToken);
        }

        public static async Task<ChatEntity> FindChatByIdIncludeMessagesAsync(this DbSet<ChatEntity> dbSet,
            string chatId, CancellationToken cancellationToken)
        {
            return await dbSet.Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == chatId, cancellationToken);
        }

        public static async Task<ChatEntity> FindChatByIdIncludeChatUsersAsync(this DbSet<ChatEntity> dbSet,
            string chatId, CancellationToken cancellationToken)
        {
            return await dbSet.Include(x => x.ChatUsers)
                .FirstOrDefaultAsync(x => x.Id == chatId, cancellationToken);
        }

        public static async Task<ChatEntity> FindPublicChanelByIdAsync(this DbSet<ChatEntity> dbSet,
            string chatId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x =>
                    x.Id == chatId && x.ChatType != ChatType.DirectChat &&
                    x.ChatType != ChatType.PrivateChannel, cancellationToken);
        }

        public static async Task<List<ChatEntity>> GetPublicChatsIncludeMessagesUsersAsync(this DbSet<ChatEntity> dbSet, 
            CancellationToken cancellationToken)
        {
            return await dbSet.AsNoTracking()
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.ChatType != ChatType.PrivateChannel)
                .Where(x => x.ChatType != ChatType.DirectChat)
                .ToListAsync(cancellationToken);
        }
    }
}
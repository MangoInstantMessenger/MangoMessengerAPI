using System;
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
        public static async Task<List<ChatEntity>> GetUserChatsAsync(this DbSet<ChatEntity> dbSet,
            Guid userId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Include(chatEntity => chatEntity.ChatUsers)
                .Where(chatEntity => (chatEntity.CommunityType == (int) CommunityType.DirectChat ||
                                      chatEntity.CommunityType == (int) CommunityType.SecretChat) &&
                                     chatEntity.ChatUsers.Any(userChatEntity => userChatEntity.UserId == userId))
                .ToListAsync(cancellationToken);
        }

        public static async Task<ChatEntity> FindChatByIdAsync(this DbSet<ChatEntity> dbSet,
            Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == chatId, cancellationToken);
        }

        public static async Task<ChatEntity> FindChatByIdIncludeMessagesAsync(this DbSet<ChatEntity> dbSet,
            Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == chatId, cancellationToken);
        }

        public static async Task<ChatEntity> FindChatByIdIncludeChatUsersAsync(this DbSet<ChatEntity> dbSet,
            Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Include(x => x.ChatUsers)
                .FirstOrDefaultAsync(x => x.Id == chatId, cancellationToken);
        }

        public static async Task<ChatEntity> FindChannelByIdAsync(this DbSet<ChatEntity> dbSet,
            Guid chatId, CancellationToken cancellationToken)
        {
            return await dbSet
                .FirstOrDefaultAsync(x => x.Id == chatId 
                                          && x.CommunityType != (int) CommunityType.DirectChat 
                                          && x.CommunityType != (int) CommunityType.PrivateChannel, 
                    cancellationToken);
        }
    }
}
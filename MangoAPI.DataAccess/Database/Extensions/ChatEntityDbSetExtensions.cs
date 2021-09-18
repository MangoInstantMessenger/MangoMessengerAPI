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
                .Where(chatEntity => (chatEntity.CommunityType == CommunityType.DirectChat ||
                                     chatEntity.CommunityType == CommunityType.SecretChat) &&
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
                .FirstOrDefaultAsync(x => x.Id == chatId && x.CommunityType != CommunityType.DirectChat &&
                                                        x.CommunityType != CommunityType.PrivateChannel, cancellationToken);
        }

        public static async Task<List<ChatEntity>> GetChannelsIncludeMessagesAsync(this DbSet<ChatEntity> dbSet,
            CancellationToken cancellationToken)
        {
            return await dbSet.AsNoTracking()
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.CommunityType != CommunityType.PrivateChannel)
                .Where(x => x.CommunityType != CommunityType.DirectChat)
                .Where(x => x.CommunityType != CommunityType.SecretChat)
                .ToListAsync(cancellationToken);
        }
    }
}
﻿using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class GetCurrentUserChatsQueryHandler : IRequestHandler<GetCurrentUserChatsQuery, GetCurrentUserChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetCurrentUserChatsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetCurrentUserChatsResponse> Handle(GetCurrentUserChatsQuery request,
            CancellationToken cancellationToken)
        {
            var query = _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.UserId == request.UserId)
                .Select(x => new Chat
                {
                    ChatId = x.ChatId,
                    Title = x.Chat.Title,
                    CommunityType = (CommunityType)x.Chat.CommunityType,
                    ChatLogoImageUrl = x.Chat.Image != null
                        ? $"{EnvironmentConstants.BackendAddress}Uploads/{x.Chat.Image}"
                        : null,
                    Description = x.Chat.Description,
                    MembersCount = x.Chat.MembersCount,
                    IsArchived = x.IsArchived,
                    IsMember = true,
                    UpdatedAt = x.Chat.UpdatedAt,
                    RoleId = x.RoleId,
                    LastMessageAuthor = x.Chat.LastMessageAuthor,
                    LastMessageText = x.Chat.LastMessageText,
                    LastMessageTime = x.Chat.LastMessageTime,
                });

            var userChats = await query
                .OrderByDescending(x => x.UpdatedAt)
                .Take(200)
                .ToListAsync(cancellationToken);

            var directChatsIds = userChats
                .Where(x => x.CommunityType == CommunityType.DirectChat)
                .Select(x => x.ChatId)
                .ToList();

            var colleagues = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.User)
                .Where(x => directChatsIds.Contains(x.ChatId) && x.UserId != request.UserId)
                .Select(x => x)
                .ToListAsync(cancellationToken);

            foreach (var userChat in userChats)
            {
                var currentChat = userChat;

                if (currentChat.CommunityType is not CommunityType.DirectChat)
                {
                    continue;
                }

                var colleague = colleagues
                    .FirstOrDefault(x => x.ChatId == currentChat.ChatId)?.User;

                currentChat.Title = colleague?.DisplayName;
                currentChat.ChatLogoImageUrl = colleague?.Image != null
                    ? $"{EnvironmentConstants.BackendAddress}Uploads/{colleague.Image}"
                    : null;
            }

            //userChats = userChats.OrderByDescending(x => x.UpdatedAt).ToList();

            return GetCurrentUserChatsResponse.FromSuccess(userChats);
        }
    }
}
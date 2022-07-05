using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public class GetCurrentUserChatsQueryHandler
    : IRequestHandler<GetCurrentUserChatsQuery, Result<GetCurrentUserChatsResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<GetCurrentUserChatsResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public GetCurrentUserChatsQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<GetCurrentUserChatsResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<GetCurrentUserChatsResponse>> Handle(
        GetCurrentUserChatsQuery request,
        CancellationToken cancellationToken)
    {
        var query = dbContext.UserChats
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
                    ? $"{blobServiceSettings.MangoBlobAccess}/{x.Chat.Image}"
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
                LastMessageId = x.Chat.LastMessageId,
            }).OrderByDescending(x => x.UpdatedAt).Take(200);

        var userChats = await query.ToListAsync(cancellationToken);

        var directChatsIds = userChats
            .Where(x => x.CommunityType == CommunityType.DirectChat)
            .Select(x => x.ChatId)
            .ToList();

        var colleagues = await dbContext.UserChats
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
                ? $"{blobServiceSettings.MangoBlobAccess}/{colleague.Image}"
                : null;
        }

        return responseFactory.SuccessResponse(GetCurrentUserChatsResponse.FromSuccess(userChats));
    }
}

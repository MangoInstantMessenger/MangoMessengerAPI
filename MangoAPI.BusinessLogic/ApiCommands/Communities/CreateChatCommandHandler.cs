using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChatCommandHandler
    : IRequestHandler<CreateChatCommand, Result<CreateCommunityResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly IHubContext<ChatHub, IHubClient> hubContext;
    private readonly ResponseFactory<CreateCommunityResponse> responseFactory;

    public CreateChatCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<CreateCommunityResponse> responseFactory)
    {
        this.dbContext = dbContext;
        this.hubContext = hubContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<CreateCommunityResponse>> Handle(
        CreateChatCommand request,
        CancellationToken cancellationToken)
    {
        var partner = await dbContext.Users.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == request.PartnerId, cancellationToken);

        if (partner is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        if (request.UserId == request.PartnerId)
        {
            const string errorMessage = ResponseMessageCodes.CannotCreateSelfChat;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var currentUserDisplayName = await dbContext.Users.Where(x => x.Id == request.UserId)
            .Select(x => x.DisplayName)
            .FirstOrDefaultAsync(cancellationToken);

        var userPrivateChats = await dbContext.Chats
            .Include(chatEntity => chatEntity.ChatUsers)
            .Where(chatEntity => chatEntity.CommunityType == CommunityType.DirectChat &&
                                 chatEntity.ChatUsers.Any(userChatEntity => userChatEntity.UserId == request.UserId))
            .ToListAsync(cancellationToken);

        var existingChat = userPrivateChats
            .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id)
                                 && x.CommunityType == CommunityType.DirectChat);

        if (existingChat != null)
        {
            return responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(existingChat));
        }

        // var chatEntity = new ChatEntity
        // {
        //     Id = Guid.NewGuid(),
        //     CommunityType = CommunityType.DirectChat,
        //     Title = $"{currentUserDisplayName} / {partner.DisplayName}",
        //     CreatedAt = DateTime.UtcNow,
        //     Description = $"Direct chat between {currentUserDisplayName} and {partner.DisplayName}",
        //     MembersCount = 2,
        // };

        var title = $"{currentUserDisplayName} / {partner.DisplayName}";
        var description = $"Direct chat between {currentUserDisplayName} and {partner.DisplayName}";

        var chat = ChatEntity.Create(
            title,
            CommunityType.DirectChat,
            description,
            image: null,
            DateTime.UtcNow,
            membersCount: 2);

        var senderUserChat = UserChatEntity.Create(request.UserId, chat.Id, UserRole.User);
        var receiverUserChat = UserChatEntity.Create(request.PartnerId, chat.Id, UserRole.User);

        // var userChats = new[]
        // {
        //     new UserChatEntity { ChatId = chat.Id, RoleId = UserRole.User, UserId = request.UserId },
        //     new UserChatEntity { ChatId = chat.Id, RoleId = UserRole.User, UserId = request.PartnerId },
        // };

        dbContext.Chats.Add(chat);
        dbContext.UserChats.AddRange(senderUserChat, receiverUserChat);

        await dbContext.SaveChangesAsync(cancellationToken);

        var chatDto = chat.ToChatDto();
        await hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChatsAsync(chatDto);

        return responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(chat));
    }
}
using MangoAPI.Application.Interfaces;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Notifications;
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
    private readonly IBlobServiceSettings blobServiceSettings;

    public CreateChatCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<CreateCommunityResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.hubContext = hubContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
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

        var senderData = await dbContext.Users.Where(x => x.Id == request.UserId)
            .Select(x => new { x.DisplayName, x.ImageFileName })
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

        var title = $"{senderData.DisplayName} / {partner.DisplayName}";
        var description = $"Direct chat between {senderData.DisplayName} and {partner.DisplayName}";

        var chat = ChatEntity.Create(
            title,
            CommunityType.DirectChat,
            description,
            image: String.Empty,
            DateTime.UtcNow,
            membersCount: 2);

        var senderUserChat = UserChatEntity.Create(request.UserId, chat.Id, UserRole.User);
        var receiverUserChat = UserChatEntity.Create(request.PartnerId, chat.Id, UserRole.User);

        dbContext.Chats.Add(chat);
        dbContext.UserChats.AddRange(senderUserChat, receiverUserChat);

        await dbContext.SaveChangesAsync(cancellationToken);

        var partnerImageUrl = $"{blobServiceSettings.MangoBlobAccess}/{senderData.ImageFileName}";

        var chatCreatedNotification = new PrivateChatCreatedNotification(
            chat.Id,
            senderData.DisplayName,
            chat.CommunityType,
            chat.Description,
            chat.MembersCount,
            IsArchived: false,
            IsMember: true,
            partnerImageUrl);

        await hubContext.Clients.Group(request.PartnerId.ToString()).PrivateChatCreatedAsync(chatCreatedNotification);

        return responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(chat));
    }
}
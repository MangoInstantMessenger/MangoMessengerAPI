using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChannelCommandHandler
    : IRequestHandler<CreateChannelCommand, Result<CreateCommunityResponse>>
{
    private const string DefaultChannelImage = "default_group_logo.png";
    private readonly MangoDbContext dbContext;
    private readonly IHubContext<ChatHub, IHubClient> hubContext;
    private readonly ResponseFactory<CreateCommunityResponse> responseFactory;

    public CreateChannelCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<CreateCommunityResponse> responseFactory)
    {
        this.dbContext = dbContext;
        this.hubContext = hubContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<CreateCommunityResponse>> Handle(
        CreateChannelCommand request,
        CancellationToken cancellationToken)
    {
        var ownerChatsCount =
            await dbContext.UserChats
                .Where(x => x.RoleId == UserRole.Owner && x.UserId == request.UserId)
                .CountAsync(cancellationToken);

        if (ownerChatsCount >= 100)
        {
            const string errorMessage = ResponseMessageCodes.MaximumOwnerChatsExceeded100;
            var description = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, description);
        }

        // var channel = new ChatEntity
        // {
        //     CommunityType = CommunityType.PublicChannel,
        //     Title = request.ChannelTitle,
        //     CreatedAt = DateTime.UtcNow,
        //     Description = request.ChannelDescription,
        //     MembersCount = 1,
        //     Image = "default_group_logo.png",
        // };

        var chat = ChatEntity.Create(
            request.ChannelTitle,
            CommunityType.PublicChannel,
            request.ChannelDescription,
            DefaultChannelImage,
            DateTime.UtcNow,
            membersCount: 1);

        var userChat = UserChatEntity.Create(request.UserId, chat.Id, UserRole.Owner);

        dbContext.Chats.Add(chat);

        dbContext.UserChats.Add(userChat);

        await dbContext.SaveChangesAsync(cancellationToken);

        var chatDto = chat.ToChatDto();
        await hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChatsAsync(chatDto);

        return responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(chat));
    }
}
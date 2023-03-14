using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChannelCommandHandler
    : IRequestHandler<CreateChannelCommand, Result<CreateCommunityResponse>>
{
    private const string DefaultChannelImage = "default_group_logo.png";
    private readonly MangoDbContext dbContext;
    // private readonly IHubContext<ChatHub, IHubClient> hubContext;
    private readonly ResponseFactory<CreateCommunityResponse> responseFactory;
    // private readonly IBlobServiceSettings blobServiceSettings;

    public CreateChannelCommandHandler(
        MangoDbContext dbContext,
        // IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<CreateCommunityResponse> responseFactory
        // IBlobServiceSettings blobServiceSettings
        )
    {
        this.dbContext = dbContext;
        // this.hubContext = hubContext;
        this.responseFactory = responseFactory;
        // this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<CreateCommunityResponse>> Handle(
        CreateChannelCommand request,
        CancellationToken cancellationToken)
    {
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

        // var chatLogoImageUrl = $"{blobServiceSettings.MangoBlobAccess}/{DefaultChannelImage}";

        // var chatDto = chat.ToChatDto(chatLogoImageUrl);
        // await hubContext.Clients.Group(request.UserId.ToString()).PrivateChatCreatedAsync(chatDto);

        return responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(chat));
    }
}
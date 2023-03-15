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
    private readonly ResponseFactory<CreateCommunityResponse> responseFactory;

    public CreateChannelCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<CreateCommunityResponse> responseFactory
    )
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
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

        return responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(chat));
    }
}
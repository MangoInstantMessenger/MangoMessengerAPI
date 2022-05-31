using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChannelCommandHandler 
    : IRequestHandler<CreateChannelCommand, Result<CreateCommunityResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly IHubContext<ChatHub, IHubClient> _hubContext;
    private readonly ResponseFactory<CreateCommunityResponse> _responseFactory;

    public CreateChannelCommandHandler(MangoDbContext dbContext, 
        IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<CreateCommunityResponse> responseFactory)
    {
        _dbContext = dbContext;
        _hubContext = hubContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CreateCommunityResponse>> Handle(CreateChannelCommand request,
        CancellationToken cancellationToken)
    {
        var ownerChatsCount =
            await _dbContext.UserChats
                .Where(x => x.RoleId == (int)UserRole.Owner && x.UserId == request.UserId)
                .CountAsync(cancellationToken);

        if (ownerChatsCount >= 100)
        {
            const string errorMessage = ResponseMessageCodes.MaximumOwnerChatsExceeded100;
            var description = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, description);
        }

        var channel = new ChatEntity
        {
            CommunityType = (int)CommunityType.PublicChannel,
            Title = request.ChannelTitle,
            CreatedAt = DateTime.UtcNow,
            Description = request.ChannelDescription,
            MembersCount = 1,
        };

        _dbContext.Chats.Add(channel);

        _dbContext.UserChats.Add(new UserChatEntity
        {
            ChatId = channel.Id,
            RoleId = (int)UserRole.Owner,
            UserId = request.UserId,
        });

        await _dbContext.SaveChangesAsync(cancellationToken);

        var chatDto = channel.ToChatDto();
        await _hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChatsAsync(chatDto);

        return _responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(channel));
    }
}
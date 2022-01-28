using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
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
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChatCommandHandler 
    : IRequestHandler<CreateChatCommand, Result<CreateCommunityResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly IHubContext<ChatHub, IHubClient> _hubContext;
    private readonly ResponseFactory<CreateCommunityResponse> _responseFactory;

    public CreateChatCommandHandler(MangoPostgresDbContext postgresDbContext, 
        IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<CreateCommunityResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _hubContext = hubContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CreateCommunityResponse>> Handle(CreateChatCommand request,
        CancellationToken cancellationToken)
    {
        var partner = await _postgresDbContext.Users.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == request.PartnerId, cancellationToken);

        if (partner is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        if (request.UserId == request.PartnerId)
        {
            const string errorMessage = ResponseMessageCodes.CannotCreateSelfChat;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var currentUserDisplayName = await _postgresDbContext.Users.Where(x => x.Id == request.UserId)
            .Select(x => x.DisplayName)
            .FirstOrDefaultAsync(cancellationToken);

        var userPrivateChats = await _postgresDbContext.Chats
            .Include(chatEntity => chatEntity.ChatUsers)
            .Where(chatEntity => chatEntity.CommunityType == (int)CommunityType.DirectChat &&
                                 chatEntity.ChatUsers.Any(userChatEntity => userChatEntity.UserId == request.UserId))
            .ToListAsync(cancellationToken);

        var existingChat = userPrivateChats
            .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id)
                                 && x.CommunityType == (int)request.CommunityType);

        if (existingChat != null)
        {
            return _responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(existingChat));
        }

        var chatEntity = new ChatEntity
        {
            Id = Guid.NewGuid(),
            CommunityType = 1,
            Title = $"{currentUserDisplayName} / {partner.DisplayName}",
            CreatedAt = DateTime.UtcNow,
            Description = $"Direct chat between {currentUserDisplayName} and {partner.DisplayName}",
            MembersCount = 2,
        };

        var userChats = new[]
        {
            new UserChatEntity {ChatId = chatEntity.Id, RoleId = (int) UserRole.User, UserId = request.UserId},
            new UserChatEntity {ChatId = chatEntity.Id, RoleId = (int) UserRole.User, UserId = request.PartnerId},
        };

        _postgresDbContext.Chats.Add(chatEntity);
        _postgresDbContext.UserChats.AddRange(userChats);

        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        var chatDto = chatEntity.ToChatDto();
        await _hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChatsAsync(chatDto);

        return _responseFactory.SuccessResponse(CreateCommunityResponse.FromSuccess(chatEntity));
    }
}
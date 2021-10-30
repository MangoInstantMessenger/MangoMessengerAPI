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
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChannelCommandHandler 
        : IRequestHandler<CreateChannelCommand, Result<CreateCommunityResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;
        private readonly ResponseFactory<CreateCommunityResponse> _responseFactory;

        public CreateChannelCommandHandler(MangoPostgresDbContext postgresDbContext, 
            IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<CreateCommunityResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<CreateCommunityResponse>> Handle(CreateChannelCommand request,
            CancellationToken cancellationToken)
        {
            if (request.CommunityType is CommunityType.DirectChat or CommunityType.SecretChat)
            {
                const string message = ResponseMessageCodes.InvalidGroupType;
                var description = ResponseMessageCodes.ErrorDictionary[message];

                return _responseFactory.ConflictResponse(message, description);
            }

            var ownerChatsCount =
                await _postgresDbContext.UserChats
                    .Where(x => x.RoleId == (int)UserRole.Owner && x.UserId == request.UserId)
                    .CountAsync(cancellationToken);

            if (ownerChatsCount >= 100)
            {
                const string message = ResponseMessageCodes.MaximumOwnerChatsExceeded100;
                var description = ResponseMessageCodes.ErrorDictionary[message];

                return _responseFactory.ConflictResponse(message, description);
            }

            var channel = new ChatEntity
            {
                CommunityType = (int)request.CommunityType,
                Title = request.ChannelTitle,
                CreatedAt = DateTime.UtcNow,
                Description = request.ChannelDescription,
                MembersCount = 1,
            };

            _postgresDbContext.Chats.Add(channel);

            _postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = channel.Id,
                RoleId = (int)UserRole.Owner,
                UserId = request.UserId,
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var chatDto = channel.ToChatDto();
            await _hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChats(chatDto);

            return new Result<CreateCommunityResponse>()
            {
                Error = null,
                Response = CreateCommunityResponse.FromSuccess(channel),
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChannelCommandHandler : IRequestHandler<CreateChannelCommand, CreateCommunityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public CreateChannelCommandHandler(MangoPostgresDbContext postgresDbContext, IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<CreateCommunityResponse> Handle(CreateChannelCommand request,
            CancellationToken cancellationToken)
        {
            if (request.CommunityType is CommunityType.DirectChat or CommunityType.SecretChat)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidGroupType);
            }

            var channel = new ChatEntity
            {
                CommunityType = (int)request.CommunityType,
                Title = request.ChannelTitle,
                CreatedAt = DateTime.UtcNow,
                Description = request.ChannelDescription,
                MembersCount = 1,
            };

            await _postgresDbContext.Chats.AddAsync(channel, cancellationToken);

            _postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = channel.Id,
                RoleId = (int)UserRole.Owner,
                UserId = request.UserId,
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var chatDto = channel.ToChatDto();
            await _hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChats(chatDto);

            return CreateCommunityResponse.FromSuccess(channel);
        }
    }
}
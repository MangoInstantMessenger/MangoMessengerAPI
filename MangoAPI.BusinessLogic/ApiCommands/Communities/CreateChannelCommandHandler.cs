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

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChannelCommandHandler 
        : IRequestHandler<CreateChannelCommand, GenericResponse<CreateCommunityResponse, ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public CreateChannelCommandHandler(MangoPostgresDbContext postgresDbContext, IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<GenericResponse<CreateCommunityResponse, ErrorResponse>> Handle(CreateChannelCommand request,
            CancellationToken cancellationToken)
        {
            if (request.CommunityType is CommunityType.DirectChat or CommunityType.SecretChat)
            {
                return new GenericResponse<CreateCommunityResponse, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidGroupType,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidGroupType],
                        StatusCode = 409,
                        Success = false,
                    },

                    Response = null,
                    StatusCode = 409
                };
            }

            var ownerChatsCount =
                await _postgresDbContext.UserChats
                    .Where(x => x.RoleId == (int)UserRole.Owner && x.UserId == request.UserId)
                    .CountAsync(cancellationToken);

            if (ownerChatsCount >= 100)
            {
                return new GenericResponse<CreateCommunityResponse, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.MaximumOwnerChatsExceeded100,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.MaximumOwnerChatsExceeded100],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
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

            return new GenericResponse<CreateCommunityResponse, ErrorResponse>()
            {
                Error = null,
                Response = CreateCommunityResponse.FromSuccess(channel),
                StatusCode = 200
            };
        }
    }
}
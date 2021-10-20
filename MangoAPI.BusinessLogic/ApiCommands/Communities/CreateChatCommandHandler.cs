using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
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

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChatCommandHandler 
        : IRequestHandler<CreateChatCommand, GenericResponse<CreateCommunityResponse, ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public CreateChatCommandHandler(MangoPostgresDbContext postgresDbContext, IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<GenericResponse<CreateCommunityResponse, ErrorResponse>> Handle(CreateChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _postgresDbContext.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.PartnerId, cancellationToken);

            if (partner is null)
            {
                return new GenericResponse<CreateCommunityResponse, ErrorResponse>
                {
                    Error = new ErrorResponse()
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            if (partner.PublicKey == 0 && request.CommunityType == CommunityType.SecretChat)
            {
                return new GenericResponse<CreateCommunityResponse, ErrorResponse>
                {
                    Error = new ErrorResponse()
                    {
                        ErrorMessage = ResponseMessageCodes.UserPublicKeyIsNotGenerated,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserPublicKeyIsNotGenerated],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            if (request.UserId == request.PartnerId)
            {
                return new GenericResponse<CreateCommunityResponse, ErrorResponse>
                {
                    Error = new ErrorResponse()
                    {
                        ErrorMessage = ResponseMessageCodes.CannotCreateSelfChat,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.CannotCreateSelfChat],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var currentUserDisplayName = await _postgresDbContext.Users.Where(x => x.Id == request.UserId)
                .Select(x => x.DisplayName)
                .FirstOrDefaultAsync(cancellationToken);

            var userPrivateChats = await _postgresDbContext.Chats
                .GetUserChatsAsync(request.UserId, cancellationToken);

            var existingChat = userPrivateChats
                .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id)
                                     && x.CommunityType == (int)request.CommunityType);

            if (existingChat != null)
            {
                return new GenericResponse<CreateCommunityResponse, ErrorResponse>
                {
                    Error = null,
                    Response = CreateCommunityResponse.FromSuccess(existingChat),
                    StatusCode = 200
                };
            }

            var chatEntity = new ChatEntity
            {
                Id = Guid.NewGuid(),
                CommunityType = (int)request.CommunityType,
                Title = $"{currentUserDisplayName} / {partner.DisplayName}",
                CreatedAt = DateTime.UtcNow,
                Description = $"Direct chat between {currentUserDisplayName} and {partner.DisplayName}",
                MembersCount = 2,
            };

            if (request.CommunityType == CommunityType.SecretChat)
            {
                chatEntity.Description = $"Secret chat between {currentUserDisplayName} and {partner.DisplayName}";
            }

            var userChats = new[]
            {
                new UserChatEntity {ChatId = chatEntity.Id, RoleId = (int) UserRole.User, UserId = request.UserId},
                new UserChatEntity {ChatId = chatEntity.Id, RoleId = (int) UserRole.User, UserId = request.PartnerId},
            };

            _postgresDbContext.Chats.Add(chatEntity);
            _postgresDbContext.UserChats.AddRange(userChats);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var chatDto = chatEntity.ToChatDto();
            await _hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChats(chatDto);

            return new GenericResponse<CreateCommunityResponse, ErrorResponse>
            {
                Error = null,
                Response = CreateCommunityResponse.FromSuccess(chatEntity),
                StatusCode = 200
            };
        }
    }
}
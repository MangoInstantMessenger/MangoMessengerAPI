using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, JoinChatResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IRequestMetadataService _metadataService;

        public JoinChatCommandHandler(MangoPostgresDbContext postgresDbContext,
            IRequestMetadataService metadataService)
        {
            _postgresDbContext = postgresDbContext;
            _metadataService = metadataService;
        }

        public async Task<JoinChatResponse> Handle(JoinChatCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await _metadataService.GetUserFromRequestMetadataAsync();

            if (currentUser == null)
            {
                return JoinChatResponse.UserNotFound;
            }

            var alreadyJoined = await
                _postgresDbContext.UserChats.AnyAsync(x =>
                    x.UserId == currentUser.Id && x.ChatId == request.ChatId, cancellationToken);

            if (alreadyJoined)
            {
                return JoinChatResponse.UserAlreadyJoined;
            }

            var chat = await _postgresDbContext.Chats
                .FirstOrDefaultAsync(x =>
                    x.Id == request.ChatId && x.ChatType != ChatType.DirectChat &&
                    x.ChatType != ChatType.PrivateChannel, cancellationToken);

            if (chat == null)
            {
                return JoinChatResponse.ChatNotFound;
            }

            await _postgresDbContext.UserChats.AddAsync(new UserChatEntity
            {
                ChatId = request.ChatId,
                UserId = currentUser.Id,
                RoleId = UserRole.User
            }, cancellationToken);

            chat.MembersCount += 1;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return JoinChatResponse.SuccessResponse;
        }
    }
}
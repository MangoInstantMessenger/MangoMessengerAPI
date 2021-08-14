using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Chats;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Chats
{
    public class CreateDirectChatCommandHandler : IRequestHandler<CreateDirectChatCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public CreateDirectChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.PartnerId, cancellationToken);

            if (partner is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var currentUser = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            var directChat = new ChatEntity
            {
                Id = Guid.NewGuid().ToString(),
                ChatType = ChatType.DirectChat,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}",
                Created = DateTime.UtcNow,
                MembersCount = 2
            };

            var userPrivateChats = _postgresDbContext.Chats
                .Include(chatEntity => chatEntity.ChatUsers)
                .Where(chatEntity => chatEntity.ChatType == ChatType.DirectChat && chatEntity.ChatUsers
                    .Any(userChatEntity => userChatEntity.UserId == currentUser.Id)).ToList();

            var directChatAlreadyExists =
                userPrivateChats.Any(x => x.ChatUsers
                    .Any(t => t.UserId == partner.Id));

            if (directChatAlreadyExists)
            {
                throw new BusinessException(ResponseMessageCodes.DirectChatAlreadyExists);
            }

            await _postgresDbContext.Chats.AddAsync(directChat, cancellationToken);

            var userChats = new[]
            {
                new UserChatEntity {ChatId = directChat.Id, RoleId = UserRole.User, UserId = currentUser.Id},
                new UserChatEntity {ChatId = directChat.Id, RoleId = UserRole.User, UserId = request.PartnerId}
            };

            await _postgresDbContext.UserChats.AddRangeAsync(userChats, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            return CreateChatEntityResponse.FromSuccess(directChat);
        }
    }
}
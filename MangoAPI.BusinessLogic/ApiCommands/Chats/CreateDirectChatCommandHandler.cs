namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using Domain.Entities;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class CreateDirectChatCommandHandler : IRequestHandler<CreateDirectChatCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public CreateDirectChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<CreateChatEntityResponse> Handle(
            CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.PartnerId, cancellationToken);

            if (partner is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (request.UserId == request.PartnerId)
            {
                throw new BusinessException(ResponseMessageCodes.CannotCreateSelfChat);
            }

            var currentUser = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            var userPrivateChats = await postgresDbContext.Chats
                .Include(chatEntity => chatEntity.ChatUsers)
                .Where(chatEntity => chatEntity.ChatType == ChatType.DirectChat && chatEntity.ChatUsers
                    .Any(userChatEntity => userChatEntity.UserId == currentUser.Id))
                .ToListAsync(cancellationToken);

            var findDirectChat = userPrivateChats
                .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id));

            if (findDirectChat != null)
            {
                return CreateChatEntityResponse.FromSuccess(findDirectChat);
            }

            var directChat = new ChatEntity
            {
                Id = Guid.NewGuid().ToString(),
                ChatType = ChatType.DirectChat,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}",
                Created = DateTime.UtcNow,
                MembersCount = 2,
            };

            var userChats = new[]
            {
                new UserChatEntity { ChatId = directChat.Id, RoleId = UserRole.User, UserId = currentUser.Id },
                new UserChatEntity { ChatId = directChat.Id, RoleId = UserRole.User, UserId = request.PartnerId },
            };

            await postgresDbContext.Chats.AddAsync(directChat, cancellationToken);
            await postgresDbContext.UserChats.AddRangeAsync(userChats, cancellationToken);
            await postgresDbContext.SaveChangesAsync(cancellationToken);
            return CreateChatEntityResponse.FromSuccess(directChat);
        }
    }
}

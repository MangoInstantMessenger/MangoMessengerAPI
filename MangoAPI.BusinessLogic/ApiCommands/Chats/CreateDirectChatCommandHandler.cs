using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public class CreateDirectChatCommandHandler : IRequestHandler<CreateDirectChatCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public CreateDirectChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CreateChatEntityResponse> Handle(
            CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _postgresDbContext.Users.FindUserByIdAsync(request.PartnerId, cancellationToken);

            if (partner is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (request.UserId == request.PartnerId)
            {
                throw new BusinessException(ResponseMessageCodes.CannotCreateSelfChat);
            }

            var currentUser = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            var userPrivateChats = await _postgresDbContext.Chats.GetUserPrivateChatsAsync(currentUser.Id, cancellationToken);

            var findCurrentUserDirectChat = userPrivateChats
                .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id));

            if (findCurrentUserDirectChat != null)
            {
                return CreateChatEntityResponse.FromSuccess(findCurrentUserDirectChat);
            }

            var partnerPrivateChats = await _postgresDbContext.Chats.GetUserPrivateChatsAsync(partner.Id, cancellationToken);
            
            var findPartnerDirectChat = partnerPrivateChats
                .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == currentUser.Id));
            
            if (findPartnerDirectChat != null)
            {
                return CreateChatEntityResponse.FromSuccess(findPartnerDirectChat);
            }

            var directChat = new ChatEntity
            {
                Id = Guid.NewGuid().ToString(),
                ChatType = ChatType.DirectChat,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}",
                CreatedAt = DateTime.UtcNow,
                Description = $"Direct chat between {currentUser.DisplayName} and {partner.DisplayName}",
                MembersCount = 2,
            };

            var userChats = new[]
            {
                new UserChatEntity { ChatId = directChat.Id, RoleId = UserRole.User, UserId = currentUser.Id },
                new UserChatEntity { ChatId = directChat.Id, RoleId = UserRole.User, UserId = request.PartnerId },
            };

            await _postgresDbContext.Chats.AddAsync(directChat, cancellationToken);
            await _postgresDbContext.UserChats.AddRangeAsync(userChats, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            return CreateChatEntityResponse.FromSuccess(directChat);
        }
    }
}

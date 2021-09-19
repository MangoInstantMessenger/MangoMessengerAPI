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

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommand, CreateCommunityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public CreateChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CreateCommunityResponse> Handle(CreateChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _postgresDbContext.Users.FindUserByIdAsync(request.PartnerId, cancellationToken);

            if (partner is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (partner.PublicKey == 0 && request.CommunityType == CommunityType.SecretChat)
            {
                throw new BusinessException(ResponseMessageCodes.UserPublicKeyIsNotGenerated);
            }

            if (request.UserId == request.PartnerId)
            {
                throw new BusinessException(ResponseMessageCodes.CannotCreateSelfChat);
            }

            var currentUser = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            var userPrivateChats = await _postgresDbContext.Chats
                .GetUserChatsAsync(currentUser.Id, cancellationToken);

            var existingChat = userPrivateChats
                .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id)
                                     && x.CommunityType == (int) request.CommunityType);

            if (existingChat != null)
            {
                return CreateCommunityResponse.FromSuccess(existingChat);
            }

            var directChat = new ChatEntity
            {
                Id = Guid.NewGuid(),
                CommunityType = (int) request.CommunityType,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}",
                CreatedAt = DateTime.UtcNow,
                Description = $"Direct chat between {currentUser.DisplayName} and {partner.DisplayName}",
                MembersCount = 2,
            };

            if (request.CommunityType == CommunityType.SecretChat)
            {
                directChat.Description = $"Secret chat between {currentUser.DisplayName} and {partner.DisplayName}";
            }

            var userChats = new[]
            {
                new UserChatEntity {ChatId = directChat.Id, RoleId = (int) UserRole.User, UserId = currentUser.Id},
                new UserChatEntity {ChatId = directChat.Id, RoleId = (int) UserRole.User, UserId = request.PartnerId},
            };

            await _postgresDbContext.Chats.AddAsync(directChat, cancellationToken);
            await _postgresDbContext.UserChats.AddRangeAsync(userChats, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateCommunityResponse.FromSuccess(directChat);
        }
    }
}
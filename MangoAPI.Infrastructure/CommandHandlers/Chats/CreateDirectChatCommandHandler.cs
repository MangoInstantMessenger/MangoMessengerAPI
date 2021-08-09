using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.ApiCommands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateDirectChatCommandHandler : IRequestHandler<CreateDirectChatCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public CreateDirectChatCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var partner = await _userManager.FindByIdAsync(request.PartnerId);

                if (partner is null)
                {
                    throw new BusinessException(ResponseMessageCodes.UserNotFound);
                }

                var currentUser = await _userManager.FindByIdAsync(request.UserId);

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
                await _postgresDbContext.SaveChangesAsync(cancellationToken);

                var userChats = new[]
                {
                    new UserChatEntity {ChatId = directChat.Id, RoleId = UserRole.User, UserId = currentUser.Id},
                    new UserChatEntity {ChatId = directChat.Id, RoleId = UserRole.User, UserId = request.PartnerId}
                };

                _postgresDbContext.UserChats.AddRange(userChats);

                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return CreateChatEntityResponse.FromSuccess(directChat);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
        }
    }
}
using System;
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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Chats
{
    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, JoinChatResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public JoinChatCommandHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<JoinChatResponse> Handle(JoinChatCommand request, CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var currentUser = await _userManager.FindByIdAsync(request.UserId);

                if (currentUser == null)
                {
                    throw new BusinessException(ResponseMessageCodes.UserNotFound);
                }

                var alreadyJoined = await
                    _postgresDbContext.UserChats.AnyAsync(x =>
                        x.UserId == currentUser.Id && x.ChatId == request.ChatId, cancellationToken);

                if (alreadyJoined)
                {
                    throw new BusinessException(ResponseMessageCodes.UserAlreadyJoinedGroup);
                }

                var chat = await _postgresDbContext.Chats
                    .FirstOrDefaultAsync(x =>
                        x.Id == request.ChatId && x.ChatType != ChatType.DirectChat &&
                        x.ChatType != ChatType.PrivateChannel, cancellationToken);

                if (chat == null)
                {
                    throw new BusinessException(ResponseMessageCodes.ChatNotFound);
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
                await transaction.CommitAsync(cancellationToken);

                return JoinChatResponse.SuccessResponse;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
            
        }
    }
}
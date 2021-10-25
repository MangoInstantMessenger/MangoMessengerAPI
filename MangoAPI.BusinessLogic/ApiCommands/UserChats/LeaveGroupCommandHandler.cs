using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class LeaveGroupCommandHandler 
        : IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LeaveGroupCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<Result<LeaveGroupResponse>> Handle(LeaveGroupCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                return new Result<LeaveGroupResponse>
                {
                    Error = new ErrorResponse
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

            var userChat =
                await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId,
                    cancellationToken);

            if (userChat is null)
            {
                return new Result<LeaveGroupResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.ChatNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ChatNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var chat = await _postgresDbContext.Chats.FindChatByIdIncludeChatUsersAsync(request.ChatId,
                cancellationToken);

            if (chat.CommunityType is (int) CommunityType.DirectChat or (int) CommunityType.SecretChat)
            {
                var messages = await _postgresDbContext
                    .Messages
                    .GetChatMessagesByIdAsync(chat.Id, cancellationToken);

                _postgresDbContext.Messages.RemoveRange(messages);
                _postgresDbContext.UserChats.RemoveRange(chat.ChatUsers);
                _postgresDbContext.Chats.Remove(chat);

                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                
                return new Result<LeaveGroupResponse>
                {
                    Error = null,
                    Response = LeaveGroupResponse.FromSuccess(chat.Id),
                    StatusCode = 200
                };
            }

            _postgresDbContext.UserChats.Remove(userChat);
            chat.MembersCount--;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new Result<LeaveGroupResponse>
            {
                Error = null,
                Response = LeaveGroupResponse.FromSuccess(chat.Id),
                StatusCode = 200
            };
        }
    }
}
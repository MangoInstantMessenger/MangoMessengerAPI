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
        private readonly ResponseFactory<LeaveGroupResponse> _responseFactory;

        public LeaveGroupCommandHandler(MangoPostgresDbContext postgresDbContext, 
            ResponseFactory<LeaveGroupResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<LeaveGroupResponse>> Handle(LeaveGroupCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                const string errorMessage = ResponseMessageCodes.UserNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var userChat =
                await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId,
                    cancellationToken);

            if (userChat is null)
            {
                const string errorMessage = ResponseMessageCodes.ChatNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
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
                
                return _responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
            }

            _postgresDbContext.UserChats.Remove(userChat);
            chat.MembersCount--;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
        }
    }
}
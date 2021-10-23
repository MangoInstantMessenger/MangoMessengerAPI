using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, GenericResponse<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public JoinChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase>> Handle(JoinChatCommand request, 
            CancellationToken cancellationToken)
        {
            var alreadyJoined = await
                _postgresDbContext.UserChats.IsAlreadyJoinedAsync(request.UserId, request.ChatId, cancellationToken);

            if (alreadyJoined)
            {
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserAlreadyJoinedGroup,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserAlreadyJoinedGroup],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var chat = await _postgresDbContext.Chats.FindChannelByIdAsync(request.ChatId, cancellationToken);

            if (chat == null)
            {
                return new GenericResponse<ResponseBase>
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

            _postgresDbContext.UserChats.Add(
                new UserChatEntity
                {
                    ChatId = request.ChatId,
                    UserId = request.UserId,
                    RoleId = (int) UserRole.User,
                });

            chat.MembersCount += 1;

            _postgresDbContext.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
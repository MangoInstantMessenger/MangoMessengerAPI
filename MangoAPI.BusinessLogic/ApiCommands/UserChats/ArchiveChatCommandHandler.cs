using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandHandler : IRequestHandler<ArchiveChatCommand, GenericResponse<ResponseBase,ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public ArchiveChatCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase,ErrorResponse>> Handle(ArchiveChatCommand request, CancellationToken cancellationToken)
        {
            var chat = await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId,
                cancellationToken);

            if (chat == null)
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
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

            chat.IsArchived = !chat.IsArchived;

            _postgresDbContext.UserChats.Update(chat);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase, ErrorResponse>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
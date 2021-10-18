using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class GetSecretChatPublicKeyQueryHandler : IRequestHandler<GetSecretChatPublicKeyQuery,
        GenericResponse<GetSecretChatPublicKeyResponse, ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetSecretChatPublicKeyQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<GetSecretChatPublicKeyResponse, ErrorResponse>> Handle(GetSecretChatPublicKeyQuery request,
            CancellationToken cancellationToken)
        {
            var userChat = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.Chat)
                .FirstOrDefaultAsync(x => x.ChatId == request.ChatId && x.UserId != request.UserId,
                    cancellationToken);

            if (userChat == null || userChat.Chat.CommunityType != (int) CommunityType.SecretChat)
            {
                return new GenericResponse<GetSecretChatPublicKeyResponse, ErrorResponse>
                {
                    Error = new ErrorResponse()
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

            var user = await _postgresDbContext.Users.FindUserByIdAsync(userChat.UserId, cancellationToken);

            //return GetSecretChatPublicKeyResponse.FromSuccess(user.PublicKey);
            return new GenericResponse<GetSecretChatPublicKeyResponse, ErrorResponse>
            {
                Error = null,
                Response = GetSecretChatPublicKeyResponse.FromSuccess(user.PublicKey),
                StatusCode = 200
            };
        }
    }
}

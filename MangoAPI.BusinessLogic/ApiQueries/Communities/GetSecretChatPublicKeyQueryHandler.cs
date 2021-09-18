using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class GetSecretChatPublicKeyQueryHandler : IRequestHandler<GetSecretChatPublicKeyQuery,
        GetSecretChatPublicKeyResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetSecretChatPublicKeyQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetSecretChatPublicKeyResponse> Handle(GetSecretChatPublicKeyQuery request,
            CancellationToken cancellationToken)
        {
            var userChat = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Include(x => x.Chat)
                .FirstOrDefaultAsync(x => x.ChatId == request.ChatId && x.UserId != request.UserId,
                    cancellationToken);

            if (userChat == null || userChat.Chat.CommunityType != CommunityType.SecretChat)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var user = await _postgresDbContext.Users.FindUserByIdAsync(userChat.UserId, cancellationToken);

            return GetSecretChatPublicKeyResponse.FromSuccess(user.PublicKey);
        }
    }
}

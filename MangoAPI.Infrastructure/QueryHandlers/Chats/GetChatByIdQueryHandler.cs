using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Chats
{
    public class GetChatByIdQueryHandler : IRequestHandler<GetChatByIdQuery, GetChatByIdResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetChatByIdQueryHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetChatByIdResponse> Handle(GetChatByIdQuery request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return GetChatByIdResponse.SuspiciousAction;
            }

            if (!validationResult.Success)
            {
                return GetChatByIdResponse.InvalidOrEmptyRefreshToken;
            }

            var user = await _postgresDbContext
                .Users
                .Include(x => x.UserChats)
                .FirstOrDefaultAsync(
                    x => x.Id == validationResult.RefreshToken.UserId, cancellationToken);

            if (user == null)
            {
                return GetChatByIdResponse.UserNotFound;
            }

            var belongsToChat = user.UserChats.Any(x => x.ChatId == request.ChatId);

            if (!belongsToChat)
            {
                return GetChatByIdResponse.PermissionDenied;
            }

            var chat = await _postgresDbContext
                .Chats
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == request.ChatId, cancellationToken);

            return GetChatByIdResponse.FromSuccess(chat);
        }
    }
}
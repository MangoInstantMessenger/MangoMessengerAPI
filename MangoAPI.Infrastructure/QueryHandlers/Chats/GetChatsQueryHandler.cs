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
    public class GetChatsQueryHandler : IRequestHandler<GetChatsQuery, GetChatsResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetChatsQueryHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetChatsResponse> Handle(GetChatsQuery request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return GetChatsResponse.SuspiciousAction;
            }

            if (!validationResult.Success)
            {
                return GetChatsResponse.InvalidOrEmptyRefreshToken;
            }

            var currentUser = await _postgresDbContext
                .Users
                .FirstAsync(x => x.Id == validationResult.RefreshToken.UserId, cancellationToken);

            if (currentUser == null)
            {
                return GetChatsResponse.UserNotFound;
            }

            var chats = _postgresDbContext.UserChats
                .Include(x => x.Chat)
                .ThenInclude(x => x.ChatUsers)
                .Where(x => x.UserId == currentUser.Id)
                .ToList();

            return GetChatsResponse.FromSuccess(chats);
        }
    }
}
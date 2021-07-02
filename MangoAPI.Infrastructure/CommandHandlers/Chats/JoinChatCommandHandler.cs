using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, JoinChatResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public JoinChatCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<JoinChatResponse> Handle(JoinChatCommand request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return JoinChatResponse.Suspicious;
            }

            if (!validationResult.Success)
            {
                return JoinChatResponse.InvalidRefreshToken;
            }

            var currentUser = await _postgresDbContext
                .Users
                .FirstAsync(x => x.Id == validationResult.RefreshToken.UserId, cancellationToken);

            if (currentUser == null)
            {
                return JoinChatResponse.UserNotFound;
            }

            var alreadyJoinedOrBlocked = await
                _postgresDbContext.UserChats.AnyAsync(x =>
                    x.UserId == currentUser.Id && x.ChatId == request.ChatId, cancellationToken);
            
            // TODO: add check in chat's blacklist

            if (alreadyJoinedOrBlocked)
            {
                return JoinChatResponse.UserAlreadyJoined;
            }
            
            // TODO: Check that provided chat is not private

            await _postgresDbContext.UserChats.AddAsync(new UserChatEntity
            {
                ChatId = request.ChatId,
                UserId = currentUser.Id,
                RoleId = UserRole.User
            }, cancellationToken);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return JoinChatResponse.FromSuccess;
        }
    }
}
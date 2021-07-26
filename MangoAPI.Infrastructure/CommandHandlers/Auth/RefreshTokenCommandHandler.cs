using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, RefreshTokenResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly UserManager<UserEntity> _userManager;

        public RefreshTokenCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
            _userManager = userManager;
        }

        public async Task<RefreshTokenResponse> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var refreshToken =
                await _postgresDbContext.RefreshTokens
                    .FirstOrDefaultAsync(x => x.Id == request.RefreshTokenId, cancellationToken);

            if (refreshToken is null || refreshToken.IsExpired)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            var user = await _userManager.FindByIdAsync(refreshToken.UserId);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userRefreshTokens = _postgresDbContext.RefreshTokens
                .Where(x => x.UserId == user.Id);

            var userTokensCount = await userRefreshTokens.CountAsync(cancellationToken);

            if (userTokensCount >= 5)
            {
                _postgresDbContext.RefreshTokens.RemoveRange(userRefreshTokens);
            }

            var newRefreshToken = _jwtGenerator.GenerateRefreshToken();

            var newJwtToken = _jwtGenerator.GenerateJwtToken(user);

            newRefreshToken.UserId = user.Id;

            await _postgresDbContext.RefreshTokens.AddAsync(newRefreshToken, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshTokenResponse.FromSuccess(newRefreshToken.Id, newJwtToken);
        }
    }
}
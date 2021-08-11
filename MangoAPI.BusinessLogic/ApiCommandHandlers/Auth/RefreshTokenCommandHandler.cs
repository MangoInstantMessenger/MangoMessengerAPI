using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Auth;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Auth;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Auth
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
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
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
                await transaction.CommitAsync(cancellationToken);
                
                return RefreshTokenResponse.FromSuccess(newRefreshToken.Id, newJwtToken);
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
        }
    }
}
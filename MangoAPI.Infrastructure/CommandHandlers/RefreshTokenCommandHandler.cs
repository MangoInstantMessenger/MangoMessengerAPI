using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, RefreshTokenResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IJwtRefreshService _jwtRefreshVerifier;

        public RefreshTokenCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator, IJwtRefreshService jwtRefreshVerifier)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
            _jwtRefreshVerifier = jwtRefreshVerifier;
        }

        public async Task<RefreshTokenResponse> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var validationResult =
                await _jwtRefreshVerifier.VerifyUserRefreshTokenAsync(request.RefreshTokenId, request.UserAgent, request.FingerPrint, request.IpAddress, cancellationToken);

            if (!validationResult.Success)
            {
                return new RefreshTokenResponse
                {
                    Message = "Invalid Refresh Token provided.",
                    Success = false,
                    RefreshTokenId = "N/A",
                    AccessToken = "N/A"
                };
            }

            var token = validationResult.RefreshToken;
            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == token.UserId, cancellationToken);

            if (user == null)
            {
                return await Task.FromResult(new RefreshTokenResponse
                {
                    Message = "Internal error in user fetching. Try again later.",
                    Success = false,
                    RefreshTokenId = "N/A",
                    AccessToken = "N/A"
                });
            }

            var newRefreshToken = _jwtGenerator.GenerateRefreshToken(request.UserAgent,
                request.FingerPrint, request.IpAddress);

            var newJwtToken = _jwtGenerator.GenerateJwtToken(user);

            newRefreshToken.UserId = user.Id;

            token.Revoked = DateTime.Now;

            // TODO: remove all old tokens if count greater then 5

            _postgresDbContext.RefreshTokens.Update(token);
            await _postgresDbContext.RefreshTokens.AddAsync(newRefreshToken, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return await Task.FromResult(new RefreshTokenResponse
            {
                Message = "Token refreshed successfully.",
                Success = true,
                RefreshTokenId = newRefreshToken.Id,
                AccessToken = newJwtToken
            });
        }
    }
}
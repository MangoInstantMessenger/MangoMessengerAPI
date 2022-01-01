using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<TokensResponse>>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly ResponseFactory<TokensResponse> _responseFactory;

        public LoginCommandHandler(SignInManager<UserEntity> signInManager, IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext, ResponseFactory<TokensResponse> responseFactory)
        {
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<TokensResponse>> Handle(LoginCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(userEntity => userEntity.Email == request.Email,
                    cancellationToken);

            if (user is null)
            {
                const string errorMessage = ResponseMessageCodes.InvalidCredentials;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!result.Succeeded)
            {
                const string errorMessage = ResponseMessageCodes.InvalidCredentials;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var refreshLifetime = EnvironmentConstants.MangoRefreshTokenLifetime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                const string errorMessage = ResponseMessageCodes.RefreshTokenLifeTimeError;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var session = new SessionEntity
            {
                UserId = user.Id,
                RefreshToken = Guid.NewGuid(),
                ExpiresAt = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                CreatedAt = DateTime.UtcNow,
            };
            
            var jwtToken = _jwtGenerator.GenerateJwtToken(user.Id);

            var userSessions = _postgresDbContext.Sessions
                .Where(entity => entity.UserId == user.Id);

            var userSessionsCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionsCount >= 5)
            {
                _postgresDbContext.Sessions.RemoveRange(userSessions);
            }

            _postgresDbContext.Sessions.Add(session);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var expires = ((DateTimeOffset) session.ExpiresAt).ToUnixTimeSeconds();
            var tokens = TokensResponse.FromSuccess(jwtToken, session.RefreshToken, user.Id, expires);

            return _responseFactory.SuccessResponse(tokens);
        }
    }
}
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
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
    public class LoginCommandHandler : IRequestHandler<LoginCommand, GenericResponse<TokensResponse>>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly SignInManager<UserEntity> _signInManager;

        public LoginCommandHandler(SignInManager<UserEntity> signInManager, IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext)
        {
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<TokensResponse>> Handle(LoginCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByEmailOrPhoneAsync(request.EmailOrPhone, cancellationToken);

            if (user is null)
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidCredentials,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidCredentials],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!result.Succeeded)
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidCredentials,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidCredentials],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.RefreshTokenLifeTimeError,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.RefreshTokenLifeTimeError],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var session = new SessionEntity
            {
                UserId = user.Id,
                RefreshToken = Guid.NewGuid(),
                ExpiresAt = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                CreatedAt = DateTime.UtcNow,
            };

            var rolesQuery = from userRole in _postgresDbContext.UserRoles.AsNoTracking()
                             join role in _postgresDbContext.Roles on userRole.RoleId equals role.Id
                             where userRole.UserId == session.UserId
                             select role.Name;

            var roles = await rolesQuery.ToListAsync(cancellationToken);

            var jwtToken = _jwtGenerator.GenerateJwtToken(user.Id, roles);

            var userSessions = _postgresDbContext.Sessions.GetUserSessionsById(user.Id);

            var userSessionsCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionsCount >= 5)
            {
                _postgresDbContext.Sessions.RemoveRange(userSessions);
            }

            _postgresDbContext.Sessions.Add(session);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();

            return new GenericResponse<TokensResponse>
            {
                Error = null,
                Response = TokensResponse.FromSuccess(jwtToken, session.RefreshToken, user.Id, expires),
                StatusCode = 200
            };
        }
    }
}
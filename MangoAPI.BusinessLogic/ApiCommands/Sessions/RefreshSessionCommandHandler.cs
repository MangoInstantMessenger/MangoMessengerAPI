using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, GenericResponse<TokensResponse>>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public RefreshSessionCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<GenericResponse<TokensResponse>> Handle(RefreshSessionCommand request, CancellationToken cancellationToken)
        {
            var session = await _postgresDbContext.Sessions.GetSessionByRefreshTokenAsync(request.RefreshToken,
                    cancellationToken);

            if (session is null || session.IsExpired)
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidOrExpiredRefreshToken],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == session.UserId);

            var userSessionCount = await userSessions.CountAsync(cancellationToken);

            switch (userSessionCount)
            {
                case >= 5:
                    _postgresDbContext.Sessions.RemoveRange(userSessions);
                    break;
                default:
                    _postgresDbContext.Sessions.Remove(session);
                    break;
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

            var newSession = new SessionEntity
            {
                RefreshToken = Guid.NewGuid(),
                UserId = session.UserId,
                ExpiresAt = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                CreatedAt = DateTime.UtcNow,
            };

            var rolesQuery = from userRole in _postgresDbContext.UserRoles.AsNoTracking()
                             join role in _postgresDbContext.Roles on userRole.RoleId equals role.Id
                             where userRole.UserId == session.UserId
                             select role.Name;

            var roles = await rolesQuery.ToListAsync(cancellationToken);

            var jwtToken = _jwtGenerator.GenerateJwtToken(session.UserId, roles);

            _postgresDbContext.Sessions.Add(newSession);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();

            return new GenericResponse<TokensResponse>
            {
                Error = null,
                Response = TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken, session.UserId, expires),
                StatusCode = 200
            };
        }
    }
}
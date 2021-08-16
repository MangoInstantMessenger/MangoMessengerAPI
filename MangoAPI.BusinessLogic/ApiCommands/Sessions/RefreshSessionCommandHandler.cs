using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, RefreshSessionResponse>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public RefreshSessionCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
            _userManager = userManager;
        }

        public async Task<RefreshSessionResponse> Handle(RefreshSessionCommand request,
            CancellationToken cancellationToken)
        {
            var session =
                await _postgresDbContext.Sessions
                    .FirstOrDefaultAsync(x => x.Id == request.RefreshToken, cancellationToken);

            if (session is null || session.IsExpired)
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);

            var user = await _userManager.FindByIdAsync(session.UserId);

            if (user is null) throw new BusinessException(ResponseMessageCodes.UserNotFound);

            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == user.Id);

            var userSessionCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionCount >= 5) _postgresDbContext.Sessions.RemoveRange(userSessions);

            var newSession = _jwtGenerator.GenerateRefreshSession();

            var newJwtToken = _jwtGenerator.GenerateJwtToken(user);

            newSession.UserId = user.Id;

            await _postgresDbContext.Sessions.AddAsync(newSession, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshSessionResponse.FromSuccess(newSession.Id, newJwtToken);
        }
    }
}
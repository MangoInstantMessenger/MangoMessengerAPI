namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class LogoutAllCommandHandler : IRequestHandler<LogoutAllCommand, LogoutResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LogoutAllCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<LogoutResponse> Handle(LogoutAllCommand request, CancellationToken cancellationToken)
        {
            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == request.UserId);

            if (!await userSessions.AnyAsync(cancellationToken))
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            _postgresDbContext.Sessions.RemoveRange(userSessions);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return LogoutResponse.SuccessResponse;
        }
    }
}

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class LogoutAllCommandHandler : IRequestHandler<LogoutAllCommand, LogoutResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public LogoutAllCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<LogoutResponse> Handle(LogoutAllCommand request, CancellationToken cancellationToken)
        {
            var userSessions = postgresDbContext.Sessions
                .Where(x => x.UserId == request.UserId);

            if (!await userSessions.AnyAsync(cancellationToken))
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            postgresDbContext.Sessions.RemoveRange(userSessions);

            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return LogoutResponse.SuccessResponse;
        }
    }
}

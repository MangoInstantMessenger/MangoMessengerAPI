namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public LogoutCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<LogoutResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var session = await postgresDbContext.Sessions
                .FirstOrDefaultAsync(
                    x => x.RefreshToken == request.RefreshToken,
                    cancellationToken);

            if (session is null)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            var user = await postgresDbContext.Users.FirstOrDefaultAsync(
                x => x.Id == session.UserId,
                cancellationToken);

            if (user is null || session.UserId != user.Id)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            postgresDbContext.Sessions.Remove(session);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return LogoutResponse.SuccessResponse;
        }
    }
}

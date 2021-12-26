using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public LogoutCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(LogoutCommand request,
            CancellationToken cancellationToken)
        {
            var session = await _postgresDbContext.Sessions
                .FirstOrDefaultAsync(sessionEntity => sessionEntity.RefreshToken == request.RefreshToken,
                    cancellationToken);

            if (session is null)
            {
                const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(userEntity => userEntity.Id == session.UserId, cancellationToken);

            if (user is null || session.UserId != user.Id)
            {
                const string errorMessage = ResponseMessageCodes.UserNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            _postgresDbContext.Sessions.Remove(session);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
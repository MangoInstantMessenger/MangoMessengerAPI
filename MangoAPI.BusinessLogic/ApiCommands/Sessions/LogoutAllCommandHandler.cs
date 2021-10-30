using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LogoutAllCommandHandler 
        : IRequestHandler<LogoutAllCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public LogoutAllCommandHandler(MangoPostgresDbContext postgresDbContext, 
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(LogoutAllCommand request, 
            CancellationToken cancellationToken)
        {
            var userSessions = _postgresDbContext.Sessions.GetUserSessionsById(request.UserId);

            if (!await userSessions.AnyAsync(cancellationToken))
            {
                const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            _postgresDbContext.Sessions.RemoveRange(userSessions);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}

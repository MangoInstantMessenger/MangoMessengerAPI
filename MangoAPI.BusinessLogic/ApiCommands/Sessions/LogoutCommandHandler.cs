using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LogoutCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<Result<ResponseBase>> Handle(LogoutCommand request, 
            CancellationToken cancellationToken)
        {
            var session = await _postgresDbContext.Sessions
                .GetSessionByRefreshTokenAsync(request.RefreshToken, cancellationToken);

            if (session is null)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidOrExpiredRefreshToken],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            var user = await _postgresDbContext.Users.FindUserByIdAsync(session.UserId, cancellationToken);

            if (user is null || session.UserId != user.Id)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            _postgresDbContext.Sessions.Remove(session);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new Result<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}
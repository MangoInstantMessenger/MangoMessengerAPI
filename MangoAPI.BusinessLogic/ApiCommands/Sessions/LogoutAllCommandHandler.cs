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
        : IRequestHandler<LogoutAllCommand, GenericResponse<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LogoutAllCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase>> Handle(LogoutAllCommand request, 
            CancellationToken cancellationToken)
        {
            var userSessions = _postgresDbContext.Sessions.GetUserSessionsById(request.UserId);

            if (!await userSessions.AnyAsync(cancellationToken))
            {
                return new GenericResponse<ResponseBase>
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

            _postgresDbContext.Sessions.RemoveRange(userSessions);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}

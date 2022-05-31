using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class LogoutAllCommandHandler 
    : IRequestHandler<LogoutAllCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public LogoutAllCommandHandler(MangoDbContext dbContext, 
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(LogoutAllCommand request, 
        CancellationToken cancellationToken)
    {
        var userSessions = _dbContext.Sessions
            .Where(entity => entity.UserId == request.UserId);

        var sessionExists = await userSessions.AnyAsync(cancellationToken);

        if (!sessionExists)
        {
            const string errorMessage = ResponseMessageCodes.SessionNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        _dbContext.Sessions.RemoveRange(userSessions);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
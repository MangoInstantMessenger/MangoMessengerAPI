using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class LogoutAllCommandHandler
    : IRequestHandler<LogoutAllCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public LogoutAllCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        LogoutAllCommand request,
        CancellationToken cancellationToken)
    {
        var userSessions = dbContext.Sessions
            .Where(entity => entity.UserId == request.UserId);

        dbContext.Sessions.RemoveRange(userSessions);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

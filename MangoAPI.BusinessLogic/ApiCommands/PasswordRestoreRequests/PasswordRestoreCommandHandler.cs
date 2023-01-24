using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class PasswordRestoreCommandHandler
    : IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly IUserManagerService userManager;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public PasswordRestoreCommandHandler(
        MangoDbContext dbContext,
        IUserManagerService userManager,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.userManager = userManager;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        PasswordRestoreCommand request,
        CancellationToken cancellationToken)
    {
        var restorePasswordRequest = await dbContext.PasswordRestoreRequests
            .Include(x => x.UserEntity)
            .FirstOrDefaultAsync(
                entity => entity.Id == request.RequestId,
                cancellationToken);

        if (restorePasswordRequest == null || !restorePasswordRequest.IsValid)
        {
            const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var user = restorePasswordRequest.UserEntity;

        await userManager.RemovePasswordAsync(user);

        await userManager.AddPasswordAsync(user, request.NewPassword);

        dbContext.PasswordRestoreRequests.Remove(restorePasswordRequest);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

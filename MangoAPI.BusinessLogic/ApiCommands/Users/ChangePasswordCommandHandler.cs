using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class ChangePasswordCommandHandler
    : IRequestHandler<ChangePasswordCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly IUserManagerService userManager;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public ChangePasswordCommandHandler(
        MangoDbContext dbContext,
        IUserManagerService userManager,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.userManager = userManager;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        ChangePasswordCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .FirstOrDefaultAsync(
                userEntity => userEntity.Id == request.UserId,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var currentPasswordVerified = await userManager.CheckPasswordAsync(user, request.CurrentPassword);

        if (!currentPasswordVerified)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        await userManager.RemovePasswordAsync(user);

        await userManager.AddPasswordAsync(user, request.NewPassword);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

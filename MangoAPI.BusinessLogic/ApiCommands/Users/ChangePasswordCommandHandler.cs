using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class ChangePasswordCommandHandler
    : IRequestHandler<ChangePasswordCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;
    private readonly IPasswordService passwordService;

    public ChangePasswordCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory,
        IPasswordService passwordService)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.passwordService = passwordService;
    }

    public async Task<Result<ResponseBase>> Handle(
        ChangePasswordCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .FirstOrDefaultAsync(
                userEntity => userEntity.Id == request.UserId,
                cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var currentPasswordVerified = passwordService.ValidateCredentials(user, request.CurrentPassword);

        if (!currentPasswordVerified)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        passwordService.ChangePassword(user, request.NewPassword);

        dbContext.Users.Update(user);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
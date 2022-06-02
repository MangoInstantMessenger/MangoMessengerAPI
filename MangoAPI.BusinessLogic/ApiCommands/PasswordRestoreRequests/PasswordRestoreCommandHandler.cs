using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class PasswordRestoreCommandHandler
    : IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly IUserManagerService _userManager;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public PasswordRestoreCommandHandler(
        MangoDbContext dbContext,
        IUserManagerService userManager,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _userManager = userManager;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(PasswordRestoreCommand request,
        CancellationToken cancellationToken)
    {
        var restorePasswordRequest = await _dbContext.PasswordRestoreRequests
            .FirstOrDefaultAsync(entity =>
                entity.Id == request.RequestId, cancellationToken);

        if (restorePasswordRequest == null || !restorePasswordRequest.IsValid)
        {
            const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var user = await _dbContext.Users
            .FirstOrDefaultAsync(entity => entity.Id == restorePasswordRequest.UserId, cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        await _userManager.RemovePasswordAsync(user);

        var result = await _userManager.AddPasswordAsync(user, request.NewPassword);

        if (!result.Succeeded)
        {
            const string errorMessage = ResponseMessageCodes.WeakPassword;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        _dbContext.PasswordRestoreRequests.Remove(restorePasswordRequest);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
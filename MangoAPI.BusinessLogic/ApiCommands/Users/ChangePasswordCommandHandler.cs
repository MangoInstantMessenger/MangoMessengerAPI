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
    private readonly MangoDbContext _dbContext;
    private readonly IUserManagerService _userManager;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public ChangePasswordCommandHandler(
        MangoDbContext dbContext,
        IUserManagerService userManager, 
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _userManager = userManager;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(ChangePasswordCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(userEntity => userEntity.Id == request.UserId, 
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var currentPasswordVerified = await _userManager.CheckPasswordAsync(user, request.CurrentPassword);

        if (!currentPasswordVerified)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        await _userManager.RemovePasswordAsync(user);

        var result = await _userManager.AddPasswordAsync(user, request.NewPassword);

        if (!result.Succeeded)
        {
            const string errorMessage = ResponseMessageCodes.WeakPassword;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
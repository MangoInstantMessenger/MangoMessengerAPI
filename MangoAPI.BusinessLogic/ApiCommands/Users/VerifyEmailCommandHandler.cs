using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class VerifyEmailCommandHandler
    : IRequestHandler<VerifyEmailCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public VerifyEmailCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(VerifyEmailCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(userEntity => userEntity.Email == request.Email,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        if (user.EmailCode != request.EmailCode)
        {
            const string errorMessage = ResponseMessageCodes.InvalidEmailConfirmationCode;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        if (user.EmailConfirmed)
        {
            const string errorMessage = ResponseMessageCodes.EmailAlreadyVerified;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        user.EmailConfirmed = true;

        _dbContext.Update(user);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
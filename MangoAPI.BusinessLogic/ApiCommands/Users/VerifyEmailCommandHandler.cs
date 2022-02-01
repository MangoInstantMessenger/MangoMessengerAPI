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
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(VerifyEmailCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _postgresDbContext.Users
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

        _postgresDbContext.Update(user);

        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
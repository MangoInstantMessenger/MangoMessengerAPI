using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class PasswordRestoreCommandHandler
        : IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IUserManagerService _userManager;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public PasswordRestoreCommandHandler(
            MangoPostgresDbContext postgresDbContext,
            IUserManagerService userManager,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(PasswordRestoreCommand request,
            CancellationToken cancellationToken)
        {
            var restorePasswordRequest = await _postgresDbContext.PasswordRestoreRequests
                .FirstOrDefaultAsync(entity =>
                    entity.Id == request.RequestId, cancellationToken);

            if (restorePasswordRequest == null || !restorePasswordRequest.IsValid)
            {
                const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var user = await _postgresDbContext.Users
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

            _postgresDbContext.PasswordRestoreRequests.Remove(restorePasswordRequest);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
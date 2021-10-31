using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class PasswordRestoreCommandHandler 
        : IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public PasswordRestoreCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager, ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(PasswordRestoreCommand request, 
            CancellationToken cancellationToken)
        {
            if (request.NewPassword != request.RepeatPassword)
            {
                const string errorMessage = ResponseMessageCodes.PasswordsAreNotSame;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var restorePasswordRequest =
                await _postgresDbContext.PasswordRestoreRequests.FindPasswordRestoreRequestByIdAsync(request.RequestId,
                    cancellationToken);

            if (restorePasswordRequest is not { IsValid: true })
            {
                const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var user = await _postgresDbContext.Users.FindUserByIdAsync(restorePasswordRequest.UserId,
                cancellationToken);

            if (user is null)
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

            _postgresDbContext.Users.Update(user);
            _postgresDbContext.PasswordRestoreRequests.Remove(restorePasswordRequest);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
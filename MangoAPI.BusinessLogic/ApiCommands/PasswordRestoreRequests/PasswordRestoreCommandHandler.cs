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
        : IRequestHandler<PasswordRestoreCommand, GenericResponse<ResponseBase,ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public PasswordRestoreCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<GenericResponse<ResponseBase,ErrorResponse>> Handle(PasswordRestoreCommand request, 
            CancellationToken cancellationToken)
        {
            if (request.NewPassword != request.RepeatPassword)
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.PasswordsAreNotSame,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.PasswordsAreNotSame],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var restorePasswordRequest =
                await _postgresDbContext.PasswordRestoreRequests.FindPasswordRestoreRequestByIdAsync(request.RequestId,
                    cancellationToken);

            if (restorePasswordRequest is not { IsValid: true })
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest,
                        ErrorDetails = 
                            ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var user = await _postgresDbContext.Users.FindUserByIdAsync(restorePasswordRequest.UserId,
                cancellationToken);

            if (user is null)
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            await _userManager.RemovePasswordAsync(user);

            var result = await _userManager.AddPasswordAsync(user, request.NewPassword);

            if (!result.Succeeded)
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.WeakPassword,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.WeakPassword],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            _postgresDbContext.Users.Update(user);
            _postgresDbContext.PasswordRestoreRequests.Remove(restorePasswordRequest);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase, ErrorResponse>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
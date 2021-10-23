using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class ChangePasswordCommandHandler 
        : IRequestHandler<ChangePasswordCommand, GenericResponse<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public ChangePasswordCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<GenericResponse<ResponseBase>> Handle(ChangePasswordCommand request, 
            CancellationToken cancellationToken)
        {
            if (request.CurrentPassword == request.NewPassword)
            {
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.PasswordsAreSame,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.PasswordsAreSame],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                return new GenericResponse<ResponseBase>
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

            var currentPasswordVerified = await _userManager.CheckPasswordAsync(user, request.CurrentPassword);

            if (!currentPasswordVerified)
            {
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidCredentials,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidCredentials],
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
                return new GenericResponse<ResponseBase>
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

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class VerifyEmailCommandHandler 
        : IRequestHandler<VerifyEmailCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<Result<ResponseBase>> Handle(VerifyEmailCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);

            if (user is null)
            {
                return new Result<ResponseBase>
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

            if (user.Email != request.Email)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidEmail,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidEmail],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            if (user.EmailConfirmed)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.EmailAlreadyVerified,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.EmailAlreadyVerified],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            if (user.EmailCode != request.EmailCode)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidEmailConfirmationCode);
            }

            user.EmailConfirmed = true;

            var role = new IdentityUserRole<Guid>
            {
                UserId = user.Id,
                RoleId = SeedDataConstants.UserRoleId,
            };

            if (!user.PhoneNumberConfirmed)
            {
                _postgresDbContext.UserRoles.Add(role);
            }

            _postgresDbContext.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new Result<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
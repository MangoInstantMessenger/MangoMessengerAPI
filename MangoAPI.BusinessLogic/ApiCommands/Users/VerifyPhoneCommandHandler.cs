using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class VerifyPhoneCommandHandler 
        : IRequestHandler<VerifyPhoneCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public VerifyPhoneCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<Result<ResponseBase>> Handle(VerifyPhoneCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user == null)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            if (user.PhoneNumberConfirmed)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.PhoneAlreadyVerified,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.PhoneAlreadyVerified],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            if (user.PhoneCode != request.ConfirmationCode)
            {
                return new Result<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidPhoneCode,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidPhoneCode],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            var role = new IdentityUserRole<Guid>
            {
                UserId = user.Id,
                RoleId = SeedDataConstants.UserRoleId,
            };

            if (!user.EmailConfirmed)
            {
                _postgresDbContext.UserRoles.Add(role);
            }

            user.PhoneNumberConfirmed = true;
            user.PhoneCode = 0;

            _postgresDbContext.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new Result<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}
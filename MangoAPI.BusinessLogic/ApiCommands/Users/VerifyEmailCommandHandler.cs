using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ResponseBase> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (user.Email != request.Email)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidEmail);
            }

            if (user.EmailConfirmed)
            {
                throw new BusinessException(ResponseMessageCodes.EmailAlreadyVerified);
            }

            user.EmailConfirmed = true;

            await _postgresDbContext.UserRoles.AddAsync(
                new IdentityUserRole<Guid>
                {
                    UserId = user.Id,
                    RoleId = SeedDataConstants.UserRoleId,
                }, cancellationToken);

            _postgresDbContext.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ResponseBase.SuccessResponse;
        }
    }
}
namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using Domain.Constants;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, VerifyEmailResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<VerifyEmailResponse> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

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
                new IdentityUserRole<string>
                {
                    UserId = user.Id,
                    RoleId = SeedDataConstants.UserRoleId,
                }, cancellationToken);

            _postgresDbContext.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return VerifyEmailResponse.SuccessResponse;
        }
    }
}

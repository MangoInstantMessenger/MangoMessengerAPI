namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, VerifyEmailResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<VerifyEmailResponse> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
                cancellationToken);

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

            await postgresDbContext.UserRoles.AddAsync(new IdentityUserRole<string>()
            {
                UserId = user.Id,
                RoleId = SeedDataConstants.UserRoleId,
            }, cancellationToken);

            postgresDbContext.Update(user);

            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return VerifyEmailResponse.SuccessResponse;
        }
    }
}

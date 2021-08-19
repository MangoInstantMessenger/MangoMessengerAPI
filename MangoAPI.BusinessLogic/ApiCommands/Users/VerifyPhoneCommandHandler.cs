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

    public class VerifyPhoneCommandHandler : IRequestHandler<VerifyPhoneCommand, VerifyPhoneResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public VerifyPhoneCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<VerifyPhoneResponse> Handle(VerifyPhoneCommand request,
            CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
                cancellationToken);

            if (user == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (user.PhoneNumberConfirmed)
            {
                throw new BusinessException(ResponseMessageCodes.PhoneAlreadyVerified);
            }

            if (user.ConfirmationCode != request.ConfirmationCode)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidPhoneCode);
            }

            await postgresDbContext.UserRoles.AddAsync(new IdentityUserRole<string>()
            {
                UserId = user.Id,
                RoleId = SeedDataConstants.UserRoleId,
            }, cancellationToken);

            user.PhoneNumberConfirmed = true;
            user.ConfirmationCode = 0;

            postgresDbContext.Update(user);

            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return VerifyPhoneResponse.SuccessResponse;
        }
    }
}

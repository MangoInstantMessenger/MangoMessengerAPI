namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;
        private readonly UserManager<UserEntity> userManager;

        public ChangePasswordCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            this.postgresDbContext = postgresDbContext;
            this.userManager = userManager;
        }

        public async Task<ChangePasswordResponse> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var token = await userManager.GeneratePasswordResetTokenAsync(user);

            var result = await userManager.ResetPasswordAsync(user, token, request.NewPassword);

            if (!result.Succeeded)
            {
                throw new BusinessException(ResponseMessageCodes.WeakPassword);
            }

            return ChangePasswordResponse.SuccessResponse;
        }
    }
}

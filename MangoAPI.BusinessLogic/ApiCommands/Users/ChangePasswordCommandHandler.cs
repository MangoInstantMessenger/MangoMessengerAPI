namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using Domain.Constants;
    using Domain.Entities;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public ChangePasswordCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<ChangePasswordResponse> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var currentPasswordVerified = await _userManager.CheckPasswordAsync(user, request.CurrentPassword);

            if (!currentPasswordVerified)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidCredentials);
            }
            
            await _userManager.RemovePasswordAsync(user);

            var result = await _userManager.AddPasswordAsync(user, request.NewPassword);

            if (!result.Succeeded)
            {
                throw new BusinessException(ResponseMessageCodes.WeakPassword);
            }
            
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ChangePasswordResponse.SuccessResponse;
        }
    }
}

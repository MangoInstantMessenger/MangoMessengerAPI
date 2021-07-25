using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class VerifyPhoneCommandHandler : IRequestHandler<VerifyPhoneCommand, VerifyPhoneResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public VerifyPhoneCommandHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<VerifyPhoneResponse> Handle(VerifyPhoneCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            if (user == null)
            {
                return VerifyPhoneResponse.UserNotFound;
            }

            if (user.PhoneNumberConfirmed)
            {
                return VerifyPhoneResponse.PhoneAlreadyVerified;
            }

            user.PhoneNumberConfirmed = true;
            user.ConfirmationCode = 0;
            
            _postgresDbContext.Update(user);
            
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return VerifyPhoneResponse.SuccessResponse;
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class VerifyPhoneCommandHandler : IRequestHandler<VerifyPhoneCommand, VerifyPhoneResponse>
    {
        private readonly MangoPostgresDbContext _dbContext;

        public VerifyPhoneCommandHandler(MangoPostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VerifyPhoneResponse> Handle(VerifyPhoneCommand request,
            CancellationToken cancellationToken)
        {
            var userEntity = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.ConfirmationCode == request.ConfirmationCode,
                    cancellationToken);

            if (userEntity == null)
                return VerifyPhoneResponse.InvalidOrExpired;

            if (userEntity.PhoneNumberConfirmed)
            {
                return VerifyPhoneResponse.PhoneAlreadyVerified;
            }

            userEntity.PhoneNumberConfirmed = true;
            userEntity.ConfirmationCode = 0;
            
            _dbContext.Update(userEntity);
            
            await _dbContext.SaveChangesAsync(cancellationToken);

            return VerifyPhoneResponse.SuccessResponse;
        }
    }
}
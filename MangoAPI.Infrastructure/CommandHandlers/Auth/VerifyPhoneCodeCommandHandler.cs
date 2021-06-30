using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class VerifyPhoneCodeCommandHandler : IRequestHandler<VerifyPhoneCodeCommand, VerifyPhoneCodeResponse>
    {
        private readonly MangoPostgresDbContext _dbContext;

        public VerifyPhoneCodeCommandHandler(MangoPostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VerifyPhoneCodeResponse> Handle(VerifyPhoneCodeCommand request,
            CancellationToken cancellationToken)
        {
            var validRequestCode = int.TryParse(request.ValidationCode, out var parsedValidationCode);

            if (!validRequestCode)
                return VerifyPhoneCodeResponse.InvalidOrExpired;

            var userEntity = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.ConfirmationCode == parsedValidationCode,
                    cancellationToken);

            if (userEntity == null)
                return VerifyPhoneCodeResponse.InvalidOrExpired;

            userEntity.EmailConfirmed = true;
            userEntity.ConfirmationCode = 0;
            _dbContext.Update(userEntity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            return VerifyPhoneCodeResponse.SuccessResponse;
        }
    }
}
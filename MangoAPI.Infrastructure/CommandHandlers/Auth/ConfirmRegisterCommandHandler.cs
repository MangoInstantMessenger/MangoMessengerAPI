using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class ConfirmRegisterCommandHandler : IRequestHandler<ConfirmRegisterCommand, ConfirmRegisterResponse>
    {
        private readonly MangoPostgresDbContext _dbContext;

        public ConfirmRegisterCommandHandler(MangoPostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ConfirmRegisterResponse> Handle(ConfirmRegisterCommand request,
            CancellationToken cancellationToken)
        {
            var validRequestCode = int.TryParse(request.ValidationCode, out var parsedValidationCode);

            if (!validRequestCode)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Invalid or expired registration identifier.",
                    Success = false
                });
            }

            var userEntity = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.ConfirmationCode == parsedValidationCode,
                    cancellationToken);

            if (userEntity == null)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Invalid or expired registration identifier.",
                    Success = false
                });
            }

            userEntity.Verified = true; //ToDo: IdentityUser already has EmailConfirmed field 
            userEntity.ConfirmationCode = 0;
            _dbContext.Update(userEntity);
            await _dbContext.SaveChangesAsync(cancellationToken);


            return await Task.FromResult(new ConfirmRegisterResponse
            {
                Message = "Your email was verified successfully.",
                Success = true,
            });
        }
    }
}
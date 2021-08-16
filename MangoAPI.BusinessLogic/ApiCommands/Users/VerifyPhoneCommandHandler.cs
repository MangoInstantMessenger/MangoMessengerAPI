using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class VerifyPhoneCommandHandler : IRequestHandler<VerifyPhoneCommand, VerifyPhoneResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public VerifyPhoneCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<VerifyPhoneResponse> Handle(VerifyPhoneCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
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

            user.PhoneNumberConfirmed = true;
            user.ConfirmationCode = 0;

            _postgresDbContext.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return VerifyPhoneResponse.SuccessResponse;
        }
    }
}
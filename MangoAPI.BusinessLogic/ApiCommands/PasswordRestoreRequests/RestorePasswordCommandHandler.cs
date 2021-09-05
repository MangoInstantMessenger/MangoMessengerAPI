using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class RestorePasswordCommandHandler : IRequestHandler<RestorePasswordCommand, RestorePasswordResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IEmailSenderService _emailSenderService;

        public RestorePasswordCommandHandler(MangoPostgresDbContext postgresDbContext,
            IEmailSenderService emailSenderService)
        {
            _postgresDbContext = postgresDbContext;
            _emailSenderService = emailSenderService;
        }
        
        public async Task<RestorePasswordResponse> Handle(RestorePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByEmailOrPhoneAsync(request.EmailOrPhone, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            await _emailSenderService.SendVerificationEmailAsync(user, cancellationToken);

            var passwordRestoreRequestEntity = new PasswordRestoreRequestEntity()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = user.Id,
                Email = user.Email,
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddHours(3)
            };

            await _postgresDbContext.PasswordRestoreRequests.AddAsync(passwordRestoreRequestEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return RestorePasswordResponse.FromSuccess(passwordRestoreRequestEntity.Id);
        }
    }
}
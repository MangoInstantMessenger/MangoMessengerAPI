using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class RequestPasswordRestoreCommandHandler : IRequestHandler<RequestPasswordRestoreCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IEmailSenderService _emailSenderService;

        public RequestPasswordRestoreCommandHandler(MangoPostgresDbContext postgresDbContext,
            IEmailSenderService emailSenderService)
        {
            _postgresDbContext = postgresDbContext;
            _emailSenderService = emailSenderService;
        }

        public async Task<ResponseBase> Handle(RequestPasswordRestoreCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByEmailOrPhoneAsync(request.EmailOrPhone,
                cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var passwordRestoreRequest = new PasswordRestoreRequestEntity
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Email = user.Email,
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddHours(3),
            };

            _postgresDbContext.PasswordRestoreRequests.Add(passwordRestoreRequest);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            await _emailSenderService.SendPasswordRestoreRequest(user, passwordRestoreRequest.Id, cancellationToken);

            return ResponseBase.SuccessResponse;
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.Enums;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IEmailSenderService _emailSenderService;

        public RegisterCommandHandler(UserManager<UserEntity> userManager,
            MangoPostgresDbContext postgresDbContext, IEmailSenderService emailSenderService)
        {
            _userManager = userManager;
            _postgresDbContext = postgresDbContext;
            _emailSenderService = emailSenderService;
        }

        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (request.Email == EnvironmentConstants.EmailSenderAddress)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidEmail);
            }

            try
            {
                await _userManager.FindByEmailAsync(request.Email);
            }
            catch (InvalidOperationException)
            {
                throw new BusinessException(ResponseMessageCodes.EmailOccupied);
            }

            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber,
                cancellationToken);

            if (user != null)
            {
                throw new BusinessException(ResponseMessageCodes.PhoneOccupied);
            }
            
            UserEntity newUser;
            
            if (request.VerificationMethod == VerificationMethod.Phone)
            {
                var confirmationCode = new Random().Next(100000, 999999);
                var newUserId = Guid.NewGuid().ToString();
                
                newUser = UserEntity.Create(request.PhoneNumber, request.DisplayName,
                    newUserId, request.Email, confirmationCode);
            }
            else
            {
                var newUserId = Guid.NewGuid().ToString();
                
                newUser = UserEntity.Create(request.PhoneNumber, request.DisplayName,
                    newUserId, request.Email);
            }
            
            var result = await _userManager.CreateAsync(newUser, request.Password);

            if (!result.Succeeded)
            {
                throw new BusinessException(ResponseMessageCodes.WeakPassword);
            }

            switch (request.VerificationMethod)
            {
                case VerificationMethod.Email:
                    await _emailSenderService.SendVerificationEmailAsync(newUser, cancellationToken);
                    break;
                case VerificationMethod.Phone:
                    // TODO: Send Phone Code
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return RegisterResponse.FromSuccess(newUser);
        }
    }
}
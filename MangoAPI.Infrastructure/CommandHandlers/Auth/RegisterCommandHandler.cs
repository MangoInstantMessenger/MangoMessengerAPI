using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Enums;
using MangoAPI.DTO.Responses.Auth;
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
            if (request.Email == EnvironmentConstants.EmailSenderAddres)
            {
                return RegisterResponse.InvalidEmail;
            }

            var findByEmailAsync = await _userManager.FindByEmailAsync(request.Email);

            if (findByEmailAsync != null)
            {
                return RegisterResponse.UserAlreadyRegistered;
            }

            if (string.IsNullOrEmpty(request.DisplayName) || string.IsNullOrWhiteSpace(request.DisplayName))
            {
                return RegisterResponse.InvalidDisplayName;
            }
            
            var findByPhone =
                await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber,
                    cancellationToken);

            if (findByPhone != null)
            {
                return RegisterResponse.PhoneOccupied;
            }

            if (!request.TermsAccepted)
            {
                return RegisterResponse.TermsNotAccepted;
            }

            var userEntity = new UserEntity
            {
                PhoneNumber = request.PhoneNumber,
                DisplayName = request.DisplayName,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email
            };

            
            if (request.VerificationMethod == VerificationMethod.Phone)
            {
                var codes = _postgresDbContext.Users
                    .Select(u => u.ConfirmationCode)
                    .Where(x => x != 0);

                var confirmationCode = new Random().Next(100000, 999999);

                while (codes.Contains(userEntity.ConfirmationCode))
                {
                    confirmationCode = new Random().Next(100000, 999999);
                }

                userEntity.ConfirmationCode = confirmationCode;
            }

            switch (request.VerificationMethod)
            {
                case VerificationMethod.Email:
                    await _emailSenderService.SendVerificationEmailAsync(userEntity, cancellationToken);
                    break;
                case VerificationMethod.Phone:
                    // TODO: Send Phone Code
                    break;
                default:
                    return RegisterResponse.InvalidVerificationMethod;
            }

            var result = await _userManager.CreateAsync(userEntity, request.Password);

            if (!result.Succeeded)
            {
                return RegisterResponse.WeakPassword;
            }

            return RegisterResponse.SuccessResponse;
        }
    }
}
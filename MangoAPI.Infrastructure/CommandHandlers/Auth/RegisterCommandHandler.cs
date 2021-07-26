using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.ApiCommands.Auth;
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

            try
            {
                await _userManager.FindByEmailAsync(request.Email);
            }
            catch (InvalidOperationException)
            {
                return RegisterResponse.EmailOccupied;
            }

            if (string.IsNullOrEmpty(request.DisplayName) || string.IsNullOrWhiteSpace(request.DisplayName))
            {
                return RegisterResponse.InvalidDisplayName;
            }

            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber,
                cancellationToken);

            if (user != null)
            {
                return RegisterResponse.PhoneOccupied;
            }

            if (!request.TermsAccepted)
            {
                return RegisterResponse.TermsNotAccepted;
            }

            var newUser = new UserEntity
            {
                PhoneNumber = request.PhoneNumber,
                DisplayName = request.DisplayName,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email
            };
            
            if (request.VerificationMethod == VerificationMethod.Phone)
            {
                newUser.ConfirmationCode = new Random().Next(100000, 999999);
            }
            
            var result = await _userManager.CreateAsync(newUser, request.Password);

            if (!result.Succeeded)
            {
                return RegisterResponse.WeakPassword;
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
                    return RegisterResponse.InvalidVerificationMethod;
            }

            return RegisterResponse.FromSuccess(newUser);
        }
    }
}
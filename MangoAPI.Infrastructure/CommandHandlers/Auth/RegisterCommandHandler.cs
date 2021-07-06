using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Enums;
using MangoAPI.DTO.Responses.Auth;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
    {
        private readonly UserManager<UserEntity> _userManager;

        public RegisterCommandHandler(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var exists = await _userManager.FindByEmailAsync(request.Email);

            if (exists != null)
            {
                return RegisterResponse.UserAlreadyRegistered;
            }

            if (!request.TermsAccepted)
            {
                return RegisterResponse.TermsNotAccepted;
            }

            var userEntity = new UserEntity
            {
                PhoneNumber = request.PhoneNumber,
                DisplayName = request.Email,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email,
                ConfirmationCode = new Random().Next(100000, 999999) // TODO: handle case for duplicate codes
            };
            
            switch (request.VerificationMethod)
            {
                case VerificationMethod.Email:
                    // TODO: Send Mail
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
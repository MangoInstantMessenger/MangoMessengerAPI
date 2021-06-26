using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers
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
                return await Task.FromResult(new RegisterResponse
                {
                    Message = "Email already registered. Forgot password? Restore your password.",
                    AlreadyRegistered = true,
                    TermsAccepted = request.TermsAccepted
                });
            }

            if (!request.TermsAccepted)
            {
                return await Task.FromResult(new RegisterResponse
                {
                    Message = "In order to register accept terms of service.",
                    AlreadyRegistered = false,
                    TermsAccepted = false
                });
            }

            var userEntity = new UserEntity
            {
                DisplayName = request.Email,
                UserName = request.Email.Split('@')[0],
                Email = request.Email,
                ConfirmationCode = new Random().Next(100000, 999999)
            };

            var result = await _userManager.CreateAsync(userEntity, request.Password);

            if (result.Succeeded)
            {
                return await Task.FromResult(new RegisterResponse
                {
                    Message = "Registration was successful. Confirm your email.",
                    AlreadyRegistered = false,
                    TermsAccepted = true
                });
            }

            throw new RestException(HttpStatusCode.BadRequest);
        }
    }
}
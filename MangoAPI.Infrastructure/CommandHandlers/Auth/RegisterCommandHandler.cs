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
                DisplayName = request.Email,
                UserName = request.Email.Split('@')[0], //ToDo: nick@gmail.com and nick@yandex.ru will be the same username?
                Email = request.Email,
                ConfirmationCode = new Random().Next(100000, 999999)
            };

            var result = await _userManager.CreateAsync(userEntity, request.Password);

            if (result.Succeeded)
            {
                return RegisterResponse.SuccessResponse;
            }

            throw new RestException(HttpStatusCode.BadRequest); // ToDo: Handle case when password doesn't meet security rules
        }
    }
}
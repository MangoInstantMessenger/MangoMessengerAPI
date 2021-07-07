using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
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

        public RegisterCommandHandler(UserManager<UserEntity> userManager, MangoPostgresDbContext postgresDbContext)
        {
            _userManager = userManager;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var findByEmailAsync = await _userManager.FindByEmailAsync(request.Email);

            if (findByEmailAsync != null)
            {
                return RegisterResponse.UserAlreadyRegistered;
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
                DisplayName = request.Email,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email,
                ConfirmationCode = new Random().Next(100000, 999999) // TODO: handle case for duplicate codes
            };

            
            if (request.VerificationMethod == VerificationMethod.Phone)
            {
                var codes = _postgresDbContext.Users
                .Select(u => u.ConfirmationCode)
                .Where(x => x != 0);

                while (codes.Contains(userEntity.ConfirmationCode))
                {
                    userEntity.ConfirmationCode = new Random().Next(100000, 999999);
                }
            }

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
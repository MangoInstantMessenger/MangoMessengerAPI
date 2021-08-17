using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Enums;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
    {
        private readonly IEmailSenderService _emailSenderService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IJwtGenerator _jwtGenerator;

        public RegisterCommandHandler(UserManager<UserEntity> userManager,
            MangoPostgresDbContext postgresDbContext, IEmailSenderService emailSenderService,
            IJwtGenerator jwtGenerator)
        {
            _userManager = userManager;
            _postgresDbContext = postgresDbContext;
            _emailSenderService = emailSenderService;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (request.Email == EnvironmentConstants.EmailSenderAddress)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidEmail);
            }

            var exists = await _userManager.FindByEmailAsync(request.Email);

            if (exists != null)
            {
                throw new BusinessException(ResponseMessageCodes.EmailOccupied);
            }

            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber, cancellationToken);

            if (user != null)
            {
                throw new BusinessException(ResponseMessageCodes.PhoneOccupied);
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
                throw new BusinessException(ResponseMessageCodes.WeakPassword);
            }

            var userInfo = new UserInformationEntity
            {
                Id = Guid.NewGuid().ToString(),
                UserId = newUser.Id
            };

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

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                throw new BusinessException(ResponseMessageCodes.RefreshTokenLifeTimeError);
            }

            var newSession = new SessionEntity
            {
                Id = Guid.NewGuid().ToString(),
                RefreshToken = Guid.NewGuid().ToString(),
                UserId = newUser.Id,
                Expires = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                Created = DateTime.UtcNow
            };

            var jwtToken = _jwtGenerator.GenerateJwtToken(newUser, SeedDataConstants.UnverifiedRole);

            await _postgresDbContext.UserRoles.AddAsync(new IdentityUserRole<string>
            {
                UserId = newUser.Id,
                RoleId = SeedDataConstants.UnverifiedRoleId
            }, cancellationToken);

            await _postgresDbContext.Sessions.AddAsync(newSession, cancellationToken);
            await _postgresDbContext.UserInformation.AddAsync(userInfo, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RegisterResponse.FromSuccess(jwtToken, newSession.RefreshToken);
        }
    }
}
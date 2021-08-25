namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Interfaces;
    using BusinessExceptions;
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using Domain.Constants;
    using Domain.Entities;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
    {
        private readonly IEmailSenderService emailSenderService;
        private readonly MangoPostgresDbContext postgresDbContext;
        private readonly UserManager<UserEntity> userManager;
        private readonly IJwtGenerator jwtGenerator;

        public RegisterCommandHandler(
            UserManager<UserEntity> userManager,
            MangoPostgresDbContext postgresDbContext,
            IEmailSenderService emailSenderService,
            IJwtGenerator jwtGenerator)
        {
            this.userManager = userManager;
            this.postgresDbContext = postgresDbContext;
            this.emailSenderService = emailSenderService;
            this.jwtGenerator = jwtGenerator;
        }

        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (request.Email == EnvironmentConstants.EmailSenderAddress)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidEmail);
            }

            var exists = await postgresDbContext.Users.FindUserByEmailAsync(request.Email, cancellationToken);

            if (exists != null)
            {
                throw new BusinessException(ResponseMessageCodes.EmailOccupied);
            }

            var user = await postgresDbContext.Users.FindUserByPhoneAsync(request.PhoneNumber, cancellationToken);

            if (user != null)
            {
                throw new BusinessException(ResponseMessageCodes.PhoneOccupied);
            }

            var newUser = new UserEntity
            {
                PhoneNumber = request.PhoneNumber,
                DisplayName = request.DisplayName,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email,
                ConfirmationCode = new Random().Next(100000, 999999),
            };

            var result = await userManager.CreateAsync(newUser, request.Password);

            if (!result.Succeeded)
            {
                throw new BusinessException(ResponseMessageCodes.WeakPassword);
            }

            var userInfo = new UserInformationEntity
            {
                Id = Guid.NewGuid().ToString(),
                UserId = newUser.Id,
            };

            await emailSenderService.SendVerificationEmailAsync(newUser, cancellationToken);

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
                Created = DateTime.UtcNow,
            };

            var jwtToken = jwtGenerator.GenerateJwtToken(
                newUser,
                new List<string> { SeedDataConstants.UnverifiedRole });

            await postgresDbContext.UserRoles.AddAsync(
                new IdentityUserRole<string>
            {
                UserId = newUser.Id,
                RoleId = SeedDataConstants.UnverifiedRoleId,
            }, cancellationToken);

            await postgresDbContext.Sessions.AddAsync(newSession, cancellationToken);
            await postgresDbContext.UserInformation.AddAsync(userInfo, cancellationToken);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return RegisterResponse.FromSuccess(jwtToken, newSession.RefreshToken);
        }
    }
}

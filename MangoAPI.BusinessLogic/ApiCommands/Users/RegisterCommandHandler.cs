using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<TokensResponse>>
    {
        private readonly IEmailSenderService _emailSenderService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly Random _random;
        private readonly ResponseFactory<TokensResponse> _responseFactory;

        public RegisterCommandHandler(UserManager<UserEntity> userManager, MangoPostgresDbContext postgresDbContext,
            IEmailSenderService emailSenderService, IJwtGenerator jwtGenerator, 
            ResponseFactory<TokensResponse> responseFactory)
        {
            _userManager = userManager;
            _postgresDbContext = postgresDbContext;
            _emailSenderService = emailSenderService;
            _jwtGenerator = jwtGenerator;
            _random = new Random();
            _responseFactory = responseFactory;
        }

        public async Task<Result<TokensResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (request.Email == EnvironmentConstants.MangoEmailNotificationsAddress)
            {
                const string errorMessage = ResponseMessageCodes.InvalidEmail;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var exists = await _postgresDbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber || 
                                          x.Email == request.Email, cancellationToken);

            if (exists != null)
            {
                const string errorMessage = ResponseMessageCodes.UserAlreadyExists;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var newUser = new UserEntity
            {
                PhoneNumber = request.PhoneNumber,
                DisplayName = request.DisplayName,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email,
                EmailCode = Guid.NewGuid(),
                PhoneCode = _random.Next(100000, 999999)
            };

            var result = await _userManager.CreateAsync(newUser, request.Password);

            if (!result.Succeeded)
            {
                const string errorMessage = ResponseMessageCodes.WeakPassword;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var userInfo = new UserInformationEntity
            {
                UserId = newUser.Id,
                CreatedAt = DateTime.UtcNow,
            };

            await _emailSenderService.SendVerificationEmailAsync(newUser, cancellationToken);

            var refreshLifetime = EnvironmentConstants.MangoRefreshTokenLifetime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                const string errorMessage = ResponseMessageCodes.RefreshTokenLifeTimeError;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var newSession = new SessionEntity
            {
                RefreshToken = Guid.NewGuid(),
                UserId = newUser.Id,
                ExpiresAt = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                CreatedAt = DateTime.UtcNow,
            };

            var jwtToken = _jwtGenerator.GenerateJwtToken(newUser.Id, new List<string>
            {
                SeedDataConstants.UnverifiedRole
            });

            _postgresDbContext.UserRoles.Add(new IdentityUserRole<Guid>
            {
                UserId = newUser.Id,
                RoleId = SeedDataConstants.UnverifiedRoleId,
            });

            _postgresDbContext.Sessions.Add(newSession);
            _postgresDbContext.UserInformation.Add(userInfo);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var expires = ((DateTimeOffset)newSession.ExpiresAt).ToUnixTimeSeconds();

            return _responseFactory.SuccessResponse(TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken,
                newUser.Id, expires));
        }
    }
}
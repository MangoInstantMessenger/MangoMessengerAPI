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
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, GenericResponse<TokensResponse>>
    {
        private readonly IEmailSenderService _emailSenderService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly Random _random;

        public RegisterCommandHandler(UserManager<UserEntity> userManager, MangoPostgresDbContext postgresDbContext,
            IEmailSenderService emailSenderService, IJwtGenerator jwtGenerator)
        {
            _userManager = userManager;
            _postgresDbContext = postgresDbContext;
            _emailSenderService = emailSenderService;
            _jwtGenerator = jwtGenerator;
            _random = new Random();
        }

        public async Task<GenericResponse<TokensResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (request.Email == EnvironmentConstants.EmailSenderAddress)
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.InvalidEmail,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.InvalidEmail],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var exists = await _postgresDbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber || 
                                          x.Email == request.Email, cancellationToken);

            if (exists != null)
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserAlreadyExists,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserAlreadyExists],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var newUser = new UserEntity
            {
                PhoneNumber = request.PhoneNumber,
                DisplayName = request.DisplayName,
                UserName = Guid.NewGuid().ToString(),
                Email = request.Email,
                EmailCode = Guid.NewGuid(),
                PhoneCode = _random.Next(100000, 999999),
                PublicKey = 0,
            };

            var result = await _userManager.CreateAsync(newUser, request.Password);

            if (!result.Succeeded)
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.WeakPassword,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.WeakPassword],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var userInfo = new UserInformationEntity
            {
                UserId = newUser.Id,
                CreatedAt = DateTime.UtcNow,
            };

            await _emailSenderService.SendVerificationEmailAsync(newUser, cancellationToken);

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                return new GenericResponse<TokensResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.RefreshTokenLifeTimeError,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.RefreshTokenLifeTimeError],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
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

            return new GenericResponse<TokensResponse>
            {
                Error = null,
                Response = TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken, newUser.Id, expires),
                StatusCode = 200
            };
        }
    }
}
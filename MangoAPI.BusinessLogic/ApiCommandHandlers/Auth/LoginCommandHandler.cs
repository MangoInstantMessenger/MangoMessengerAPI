using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Auth;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Auth;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LoginCommandHandler(UserManager<UserEntity> userManager,
            SignInManager<UserEntity> signInManager,
            IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var user = await _userManager.FindByEmailAsync(request.Email);

                if (user is null)
                {
                    throw new BusinessException(ResponseMessageCodes.InvalidCredentials);
                }

                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

                if (!result.Succeeded)
                {
                    throw new BusinessException(ResponseMessageCodes.InvalidCredentials);
                }

                if (!user.Verified)
                {
                    throw new BusinessException(ResponseMessageCodes.UserNotVerified);
                }

                var refreshToken = _jwtGenerator.GenerateRefreshToken();

                var jwtToken = _jwtGenerator.GenerateJwtToken(user);

                refreshToken.UserId = user.Id;

                var userRefreshTokens = _postgresDbContext.RefreshTokens
                    .Where(x => x.UserId == user.Id);

                var userTokensCount = await userRefreshTokens.CountAsync(cancellationToken);

                if (userTokensCount >= 5)
                {
                    _postgresDbContext.RefreshTokens.RemoveRange(userRefreshTokens);
                }

                await _postgresDbContext.RefreshTokens.AddAsync(refreshToken, cancellationToken);
                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                
                return LoginResponse.FromSuccess(jwtToken, refreshToken.Id, user.Id);
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }

        }
    }
}
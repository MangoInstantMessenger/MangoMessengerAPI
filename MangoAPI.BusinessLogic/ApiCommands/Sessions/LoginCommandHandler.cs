using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Infrastructure.Database;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<TokensResponse>>
{
    private readonly IJwtGenerator _jwtGenerator;
    private readonly MangoDbContext _dbContext;
    private readonly ISignInManagerService _signInManager;
    private readonly ResponseFactory<TokensResponse> _responseFactory;
    private readonly IJwtGeneratorSettings _jwtGeneratorSettings;

    public LoginCommandHandler(
        ISignInManagerService signInManager,
        IJwtGenerator jwtGenerator,
        MangoDbContext dbContext,
        ResponseFactory<TokensResponse> responseFactory,
        IJwtGeneratorSettings jwtGeneratorSettings)
    {
        _signInManager = signInManager;
        _jwtGenerator = jwtGenerator;
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _jwtGeneratorSettings = jwtGeneratorSettings;
    }

    public async Task<Result<TokensResponse>> Handle(LoginCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(userEntity => userEntity.Email == request.Email,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        if (!user.EmailConfirmed)
        {
            const string errorMessage = ResponseMessageCodes.EmailIsNotVerified;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        if (!result.Succeeded)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }
        
        var session = new SessionEntity
        {
            UserId = user.Id,
            RefreshToken = Guid.NewGuid(),
            ExpiresAt = DateTime.UtcNow.AddDays(_jwtGeneratorSettings.MangoRefreshTokenLifetime),
            CreatedAt = DateTime.UtcNow,
        };

        var jwtToken = _jwtGenerator.GenerateJwtToken(user.Id);

        var userSessions = _dbContext.Sessions
            .Where(entity => entity.UserId == user.Id);

        var userSessionsCount = await userSessions.CountAsync(cancellationToken);

        if (userSessionsCount >= 5)
        {
            _dbContext.Sessions.RemoveRange(userSessions);
        }

        _dbContext.Sessions.Add(session);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset) session.ExpiresAt).ToUnixTimeSeconds();
        var tokens = TokensResponse.FromSuccess(jwtToken, session.RefreshToken, user.Id, expires);

        return _responseFactory.SuccessResponse(tokens);
    }
}
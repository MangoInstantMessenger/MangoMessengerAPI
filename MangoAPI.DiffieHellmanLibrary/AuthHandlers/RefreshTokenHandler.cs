using MangoAPI.DiffieHellmanLibrary.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanLibrary.AuthHandlers;

public class RefreshTokenHandler
{
    private readonly SessionsService _sessionsService;
    private readonly TokensService _tokensService;

    public RefreshTokenHandler(SessionsService sessionsService, TokensService tokensService)
    {
        _sessionsService = sessionsService;
        _tokensService = tokensService;
    }

    public async Task RefreshTokensAsync()
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        if (tokensResponse == null)
        {
            const string error = ResponseMessageCodes.TokensNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];
            Console.WriteLine($@"{error}. {details}");
            return;
        }

        var refreshToken = tokensResponse.Tokens.RefreshToken;

        Console.WriteLine(@"Refreshing tokens ...");
        var refreshTokenResponse = await _sessionsService.RefreshTokenAsync(refreshToken);

        Console.WriteLine(@"Writing tokens to file ...");
        await _tokensService.WriteTokensAsync(refreshTokenResponse);

        Console.WriteLine(@"Refresh token operation was succeeded. 
");
    }
}
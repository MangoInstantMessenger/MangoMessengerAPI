using MangoAPI.DiffieHellmanLibrary.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanLibrary.AuthHandlers;

public class RefreshTokenHandler
{
    private readonly SessionsService _sessionsService;

    public RefreshTokenHandler(SessionsService sessionsService)
    {
        _sessionsService = sessionsService;
    }

    public async Task RefreshTokensAsync()
    {
        var tokensResponse = await TokensService.GetTokensAsync();

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
        await TokensService.WriteTokensAsync(refreshTokenResponse);

        Console.WriteLine(@"Refresh token operation was succeeded.");
        Console.WriteLine();
    }
}
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.AuthHandlers;

public class RefreshTokenHandler : BaseHandler
{
    public RefreshTokenHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task RefreshTokensAsync()
    {
        var refreshToken = TokensResponse.Tokens.RefreshToken;

        Console.WriteLine(@"Refreshing tokens ...");
        var refreshTokenResponse = await PerformRefreshTokensAsync(refreshToken);

        Console.WriteLine(@"Writing tokens to file ...");
        await TokensHelper.WriteTokensAsync(refreshTokenResponse);

        Console.WriteLine(@"Refresh token operation was succeeded.");
        Console.WriteLine();
    }

    private async Task<TokensResponse> PerformRefreshTokensAsync(Guid refreshToken)
    {
        var route = AuthRoutes.SessionsRoute + refreshToken;

        var result = await HttpRequestHelper.PostWithoutBodyAsync(HttpClient, route);

        var response = JsonConvert.DeserializeObject<TokensResponse>(result);

        return response ?? throw new InvalidOperationException();
    }
}

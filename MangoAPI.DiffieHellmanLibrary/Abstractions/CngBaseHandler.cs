using System.Net.Http.Headers;
using MangoAPI.DiffieHellmanLibrary.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public abstract class CngBaseHandler
{
    protected readonly HttpClient _httpClient;

    public CngBaseHandler(HttpClient httpClient)
    {
        _httpClient = httpClient;

        var tokensResponse = TokensService.GetTokensAsync().GetAwaiter().GetResult();

        if (tokensResponse == null)
        {
            const string error = ResponseMessageCodes.TokensNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];

            throw new InvalidOperationException($"{error}. {details}, {nameof(tokensResponse)}");
        }

        var accessToken = tokensResponse.Tokens.AccessToken;

        _httpClient.DefaultRequestHeaders.Authorization
            = new AuthenticationHeaderValue("Bearer", accessToken);
    }
}
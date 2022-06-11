using System.Net.Http.Headers;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public abstract class BaseHandler
{
    protected readonly HttpClient HttpClient;
    protected readonly TokensService TokensService;

    protected BaseHandler(HttpClient httpClient, TokensService tokensService)
    {
        HttpClient = httpClient;
        TokensService = tokensService;

        var tokensResponse = TokensService.GetTokensAsync().GetAwaiter().GetResult();

        if (tokensResponse == null)
        {
            const string error = ResponseMessageCodes.TokensNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];

            throw new InvalidOperationException($"{error}. {details}, {nameof(tokensResponse)}");
        }

        var accessToken = tokensResponse.Tokens.AccessToken;

        HttpClient.DefaultRequestHeaders.Authorization
            = new AuthenticationHeaderValue("Bearer", accessToken);
    }
}
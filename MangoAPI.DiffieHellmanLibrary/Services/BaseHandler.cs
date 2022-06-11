using System.Net.Http.Headers;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

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

    protected async Task<List<OpenSslKeyExchangeRequest>> OpensslGetKeyExchangesAsync()
    {
        var uri = new Uri(OpenSslRoutes.OpenSslKeyExchangeRequests, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var deserialized =
            JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestsResponse>(responseBody) ??
            throw new InvalidOperationException("Cannot deserialize list of key exchange requests.");

        var requests = deserialized.OpenSslKeyExchangeRequests;

        return requests;
    }
}
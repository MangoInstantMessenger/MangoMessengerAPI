using System.Net.Http.Headers;
using System.Text.Json;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public abstract class BaseHandler
{
    protected HttpClient HttpClient { get; }

    protected TokensResponse TokensResponse { get; }

    protected BaseHandler(HttpClient httpClient)
    {
        HttpClient = httpClient;
        TokensResponse = TokensHelper.GetTokensAsync().GetAwaiter().GetResult();

        if (TokensResponse == null)
        {
            const string error = ResponseMessageCodes.TokensNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];

            throw new InvalidOperationException($"{error}. {details}, {nameof(TokensResponse)}");
        }

        SetBearerToken(HttpClient, TokensResponse);
    }

    protected async Task<List<OpenSslKeyExchangeRequest>> GetKeyExchangesAsync()
    {
        var uri = new Uri(KeyExchangeRoutes.KeyExchangeRequests, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var deserialized =
            JsonSerializer.Deserialize<GetKeyExchangeRequestsResponse>(responseBody, options) ??
            throw new InvalidOperationException("Cannot deserialize list of key exchange requests.");

        var requests = deserialized.OpenSslKeyExchangeRequests;

        return requests;
    }

    private static void SetBearerToken(HttpClient httpClient, TokensResponse tokensResponse)
    {
        if (tokensResponse?.Tokens?.AccessToken == null)
        {
            return;
        }

        var accessToken = tokensResponse.Tokens?.AccessToken;

        httpClient.DefaultRequestHeaders.Authorization
            = new AuthenticationHeaderValue("Bearer", accessToken);
    }
}
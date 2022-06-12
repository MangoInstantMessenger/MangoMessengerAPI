using System.Net.Http.Headers;
using MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public abstract class BaseHandler
{
    protected readonly HttpClient HttpClient;
    protected readonly TokensResponse TokensResponse;

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

        var accessToken = TokensResponse.Tokens.AccessToken;

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
    
    protected async Task<CngGetPublicKeysResponse> CngGetPublicKeys()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: HttpClient,
            route: CngRoutes.CngPublicKeys);

        var response = JsonConvert.DeserializeObject<CngGetPublicKeysResponse>(result) ??
                       throw new InvalidOperationException($"Argument is null {nameof(result)}");

        return response;
    }
    
    protected async Task<OpenSslGetKeyExchangeRequestsResponse> CngGetKeyExchangesAsync()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: HttpClient,
            route: CngRoutes.CngKeyExchangeRequests);

        var response = JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestsResponse>(result);

        return response ?? throw new InvalidOperationException();
    }
}
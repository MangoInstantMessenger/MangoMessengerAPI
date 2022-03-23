using System.Net.Http.Headers;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Consts;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public class CngKeyExchangeService
{
    private readonly HttpClient _httpClient;

    public CngKeyExchangeService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        var tokensResponse = new TokensService().GetTokensAsync().GetAwaiter().GetResult();

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

    public async Task<CngGetKeyExchangeResponse> CngGetKeyExchangesAsync()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: _httpClient,
            route: Routes.CngKeyExchangeRequests);

        var response = JsonConvert.DeserializeObject<CngGetKeyExchangeResponse>(result);

        return response ?? throw new InvalidOperationException();
    }

    public async Task<CngCreateKeyExchangeResponse> CngCreateKeyExchangeRequestAsync(
        Guid requestUserId,
        string publicKey)
    {
        var command = new CngCreateKeyExchangeRequest
        {
            PublicKey = publicKey,
            RequestedUserId = requestUserId
        };

        var result = await HttpRequestHelper.PostWithBodyAsync(
            client: _httpClient,
            route: Routes.CngKeyExchangeRequests,
            body: command);

        var response = JsonConvert.DeserializeObject<CngCreateKeyExchangeResponse>(result);

        return response ?? throw new InvalidOperationException();
    }

    public async Task CngConfirmOrDeclineKeyExchangeAsync(Guid requestId, string publicKeyBase64)
    {
        var request = new CngConfirmOrDeclineKeyExchangeRequest
        {
            Confirmed = true,
            PublicKey = publicKeyBase64,
            RequestId = requestId
        };

        await HttpRequestHelper.DeleteWithBodyAsync(
            client: _httpClient,
            route: Routes.CngKeyExchangeRequests,
            body: request);
    }
}
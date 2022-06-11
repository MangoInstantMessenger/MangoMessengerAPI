using System.Net.Http.Headers;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Constants;
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

    public async Task<CngGetKeyExchangeResponse> CngGetKeyExchangesAsync()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: _httpClient,
            route: CngRoutes.CngKeyExchangeRequests);

        var response = JsonConvert.DeserializeObject<CngGetKeyExchangeResponse>(result);

        return response ?? throw new InvalidOperationException();
    }

    public async Task<CngGetKeyExchangeRequestByIdResponse> CngGetKeyExchangeById(Guid requestId)
    {
        var result = await HttpRequestHelper.GetAsync(
            client: _httpClient,
            route: $"{CngRoutes.CngKeyExchangeRequests}/{requestId}");

        var response = JsonConvert.DeserializeObject<CngGetKeyExchangeRequestByIdResponse>(result);
        
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
            route: CngRoutes.CngKeyExchangeRequests,
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
            route: CngRoutes.CngKeyExchangeRequests,
            body: request);
    }
}
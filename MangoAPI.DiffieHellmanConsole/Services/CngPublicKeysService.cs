using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.PublicKeys;
using MangoAPI.DiffieHellmanConsole.Consts;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services;

public class CngPublicKeysService
{
    private readonly HttpClient _httpClient;

    public CngPublicKeysService(HttpClient httpClient)
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

    public async Task<GetPublicKeysResponse> CngGetPublicKeys()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: _httpClient,
            route: Routes.CngPublicKeys);

        var response = JsonConvert.DeserializeObject<GetPublicKeysResponse>(result);

        return response;
    }
}
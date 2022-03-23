using System.Net.Http.Headers;
using MangoAPI.BusinessLogic.ApiQueries.PublicKeys;
using MangoAPI.DiffieHellmanLibrary.Consts;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Services;

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

    public async Task<CngGetPublicKeysResponse> CngGetPublicKeys()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: _httpClient,
            route: Routes.CngPublicKeys);

        var response = JsonConvert.DeserializeObject<CngGetPublicKeysResponse>(result) ??
                       throw new InvalidOperationException($"Argument is null {nameof(result)}");

        return response;
    }
}
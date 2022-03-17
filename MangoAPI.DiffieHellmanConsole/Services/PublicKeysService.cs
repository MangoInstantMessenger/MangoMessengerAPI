using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.PublicKeys;
using MangoAPI.DiffieHellmanConsole.Consts;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services;

public class PublicKeysService
{
    private const string Route = "public-keys";
    private readonly HttpClient _httpClient;

    public PublicKeysService(HttpClient httpClient)
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

    public async Task<GetPublicKeysResponse> GetPublicKeys()
    {
        const string route = Urls.ApiUrl + Route;
        var result = await HttpRequest.GetAsync(_httpClient, route);
        var response = JsonConvert.DeserializeObject<GetPublicKeysResponse>(result);
        return response;
    }
}
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public class SessionsService
{
    private readonly HttpClient _httpClient;

    public SessionsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TokensResponse> LoginAsync(string login, string password)
    {
        var command = new LoginCommand(login, password);

        var response = await HttpRequestHelper.PostWithBodyAsync(
            client: _httpClient,
            route: AuthRoutes.SessionsRoute,
            body: command);

        var result = JsonConvert.DeserializeObject<TokensResponse>(response);

        return result ?? throw new InvalidOperationException();
    }

    public async Task<TokensResponse> RefreshTokenAsync(Guid refreshToken)
    {
        var route = AuthRoutes.SessionsRoute + refreshToken;

        var result = await HttpRequestHelper.PostWithoutBodyAsync(_httpClient, route);

        var response = JsonConvert.DeserializeObject<TokensResponse>(result);

        return response ?? throw new InvalidOperationException();
    }
}
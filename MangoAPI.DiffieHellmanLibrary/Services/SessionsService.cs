using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Consts;
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

    public async Task<TokensResponse> LoginAsync(IReadOnlyList<string> args)
    {
        var email = args[1];
        var password = args[2];

        var command = new LoginCommand(email, password);

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
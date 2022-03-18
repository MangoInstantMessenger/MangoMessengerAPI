using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanConsole.Consts;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services;

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

        var command = new LoginCommand
        {
            Email = email,
            Password = password
        };

        var response = await HttpRequest.PostWithBodyAsync(
            client: _httpClient,
            route: Routes.SessionsRoute,
            body: command);

        return JsonConvert.DeserializeObject<TokensResponse>(response);
    }

    public async Task<TokensResponse> RefreshTokenAsync(Guid refreshToken)
    {
        var route = Routes.SessionsRoute + refreshToken;
        
        var result = await HttpRequest.PostWithoutBodyAsync(_httpClient, route);
        
        var response = JsonConvert.DeserializeObject<TokensResponse>(result);
        
        return response;
    }
}
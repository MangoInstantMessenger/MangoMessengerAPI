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
    private const string Route = "sessions/";
    private readonly HttpClient _httpClient;

    public SessionsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TokensResponse> LoginAsync(IReadOnlyList<string> args)
    {
        var email = args[1];
        var pass = args[2];

        var command = new LoginCommand
        {
            Email = email,
            Password = pass
        };

        var response = await HttpRequest.PostWithBodyAsync(_httpClient, Urls.ApiUrl + Route, command);
        return JsonConvert.DeserializeObject<TokensResponse>(response);
    }

    public async Task<TokensResponse> RefreshTokenAsync(Guid refreshToken)
    {
        var route = Urls.ApiUrl + Route + refreshToken;
        var result = await HttpRequest.PostWithoutBodyAsync(_httpClient, route);
        var response = JsonConvert.DeserializeObject<TokensResponse>(result);
        return response;
    }
}
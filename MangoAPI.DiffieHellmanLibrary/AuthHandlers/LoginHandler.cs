using System.Text.Json;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.AuthHandlers;

public class LoginHandler : BaseHandler
{
    public LoginHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task LoginAsync(string login, string password)
    {
        Console.WriteLine(@"Attempting to login ...");
        var loginResponse = await PerformLoginAsync(login, password);

        Console.WriteLine(@"Writing tokens to file ...");
        await TokensHelper.WriteTokensAsync(loginResponse);

        Console.WriteLine(@"Login operation success.");
        Console.WriteLine();
    }

    private async Task<TokensResponse> PerformLoginAsync(string login, string password)
    {
        var command = new LoginCommand(login, password);

        var response = await HttpRequestHelper.PostWithBodyAsync(
            client: HttpClient,
            route: AuthRoutes.SessionsRoute,
            body: command);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var result = JsonSerializer.Deserialize<TokensResponse>(response, options);

        return result ?? throw new InvalidOperationException();
    }
}

using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.AuthHandlers;

public class LoginHandler
{
    private readonly SessionsService _sessionsService;

    public LoginHandler(SessionsService sessionsService)
    {
        _sessionsService = sessionsService;
    }

    public async Task LoginAsync(string login, string password)
    {
        Console.WriteLine(@"Attempting to login ...");
        var loginResponse = await _sessionsService.LoginAsync(login, password);

        Console.WriteLine(@"Writing tokens to file ...");
        await TokensService.WriteTokensAsync(loginResponse);

        Console.WriteLine(@"Login operation success.");
        Console.WriteLine();
    }
}
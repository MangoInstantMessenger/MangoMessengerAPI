using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.AuthHandlers;

public class LoginHandler
{
    private readonly SessionsService _sessionsService;
    private readonly TokensService _tokensService;

    public LoginHandler(SessionsService sessionsService, TokensService tokensService)
    {
        _sessionsService = sessionsService;
        _tokensService = tokensService;
    }

    public async Task LoginAsync(IReadOnlyList<string> args)
    {
        Console.WriteLine(@"Attempting to login ...");
        var loginResponse = await _sessionsService.LoginAsync(args);

        Console.WriteLine(@"Writing tokens to file ...");
        await _tokensService.WriteTokensAsync(loginResponse);

        Console.WriteLine(@"Login operation success.
");
    }
}
using System.Text.Json;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Extensions;

namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class TokensHelper
{
    public static async Task WriteTokensAsync(TokensResponse loginResponse)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var serializedTokens = JsonSerializer.Serialize(loginResponse, options);

        var workingDirectory = AuthDirectoryHelper.AuthWorkingDirectory;

        var tokensPath = Path.Combine(workingDirectory, "Tokens.txt");

        workingDirectory.CreateDirectoryIfNotExist();

        await File.WriteAllTextAsync(tokensPath, serializedTokens);
    }

    public static async Task<TokensResponse> GetTokensAsync()
    {
        var workingDirectory = AuthDirectoryHelper.AuthWorkingDirectory;

        var tokensPath = Path.Combine(workingDirectory, "Tokens.txt");

        workingDirectory.CreateDirectoryIfNotExist();

        var fileExists = File.Exists(tokensPath);

        if (!fileExists)
        {
            return new TokensResponse();
        }

        var readTokens = await File.ReadAllTextAsync(tokensPath);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var tokens = JsonSerializer.Deserialize<TokensResponse>(readTokens, options);

        return tokens ?? throw new InvalidOperationException();
    }
}

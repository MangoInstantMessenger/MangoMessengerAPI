using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class TokensHelper
{
    public static async Task WriteTokensAsync(TokensResponse loginResponse)
    {
        var serializedTokens = JsonConvert.SerializeObject(loginResponse);

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

        var readTokens = await File.ReadAllTextAsync(tokensPath);

        var tokens = JsonConvert.DeserializeObject<TokensResponse>(readTokens);

        return tokens ?? throw new InvalidOperationException();
    }
}
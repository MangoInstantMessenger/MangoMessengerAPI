using System;
using System.IO;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public static class TokensService
    {
        public static async Task WriteTokensAsync(TokensResponse loginResponse)
        {
            var serializedTokens = JsonConvert.SerializeObject(loginResponse);
            var path = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");

            await File.WriteAllTextAsync(path, serializedTokens);
        }

        public static async Task<TokensResponse> GetTokensAsync()
        {
            var tokensPath = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");
            var readTokens = await File.ReadAllTextAsync(tokensPath);
            var tokens = JsonConvert.DeserializeObject<TokensResponse>(readTokens);
            return tokens;
        }
    }
}
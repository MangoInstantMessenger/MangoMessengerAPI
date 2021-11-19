using System;
using System.IO;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public class TokensService
    {
        public async Task WriteToken(TokensResponse loginResponse)
        {
            var serializedTokens = JsonConvert.SerializeObject(loginResponse);
            var path = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");

            await File.WriteAllTextAsync(path, serializedTokens);
        }

        public async Task<TokensResponse> GetTokens()
        {
            var tokensPath = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");
            var readTokens = await File.ReadAllTextAsync(tokensPath);
            var tokens = JsonConvert.DeserializeObject<TokensResponse>(readTokens);
            return tokens;
        }
    }
}
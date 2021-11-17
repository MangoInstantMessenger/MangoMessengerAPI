using System.Net.Http;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanConsole.Consts;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public class SessionsService
    {
        private const string Route = "sessions/";
        private readonly HttpClient _httpClient = new();

        public async Task<TokensResponse> LoginAsync(LoginCommand command)
        {
            var response = await HttpRequest.Post(_httpClient, Urls.ApiUrl + Route, command);
            return JsonConvert.DeserializeObject<TokensResponse>(response);
        }
    }
}
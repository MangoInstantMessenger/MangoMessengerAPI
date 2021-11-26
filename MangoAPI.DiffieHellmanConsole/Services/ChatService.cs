using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.DiffieHellmanConsole.Consts;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public class ChatService
    {
        private const string Route = "communities/";
        private readonly HttpClient _httpClient;

        public ChatService(string accessToken)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        public async Task<GetCurrentUserChatsResponse> GetCurrentUserChatsAsync()
        {
            const string route = Urls.ApiUrl + Route;
            var responseJson = await HttpRequest.GetAsync(_httpClient, route);
            var response = JsonConvert.DeserializeObject<GetCurrentUserChatsResponse>(responseJson);
            return response;
        }
    }
}
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.KeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanConsole.Consts;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public class KeyExchangeService
    {
        private const string Route = "key-exchange";
        private readonly HttpClient _httpClient;

        public KeyExchangeService(string accessToken)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        public async Task<GetKeyExchangeResponse> GetKeyExchangesAsync()
        {
            var route = Urls.ApiUrl + Route;
            var result = await HttpRequest.GetAsync(_httpClient, route);
            var response = JsonConvert.DeserializeObject<GetKeyExchangeResponse>(result);
            return response;
        }

        public async Task<CreateKeyExchangeResponse> CreateKeyExchangeAsync(CreateKeyExchangeRequest request)
        {
            var route = Urls.ApiUrl + Route;
            var result = await HttpRequest.PostWithBodyAsync(_httpClient, route, request);
            var response = JsonConvert.DeserializeObject<CreateKeyExchangeResponse>(result);
            return response;
        }

        public async Task<ResponseBase> ConfirmOrDeclineKeyExchange(ConfirmOrDeclineKeyExchangeRequest request)
        {
            var route = Urls.ApiUrl + Route;
            var result = await HttpRequest.DeleteWithBodyAsync(_httpClient, route, request);
            var response = JsonConvert.DeserializeObject<CreateKeyExchangeResponse>(result);
            return response;
        }
    }
}
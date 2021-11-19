using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.KeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.PublicKeys;
using MangoAPI.DiffieHellmanConsole.Consts;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public class PublicKeysService
    {
        private const string Route = "public-keys";
        private readonly HttpClient _httpClient;

        public PublicKeysService(string accessToken)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        public async Task<GetPublicKeysResponse> GetPublicKeys()
        {
            var route = Urls.ApiUrl + Route;
            var result = await HttpRequest.GetAsync(_httpClient, route);
            var response = JsonConvert.DeserializeObject<GetPublicKeysResponse>(result);
            return response;
        }
    }
}
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole
{
    public static class HttpRequest
    {
        private static HttpRequestMessage Get(string route, object body)
        {
            var payload = JsonConvert.SerializeObject(body);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(route),
                Content = new StringContent(payload, Encoding.Default, "application/json")
            };

            return request;
        }

        public static async Task<string> Get(HttpClient httpClient, string route, object model)
        {
            var request = Get(route, model);
            var response = await httpClient.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync()
                .ConfigureAwait(false);
            return responseBody;
        }

        public static async Task<string> Post(HttpClient client, string route, object body)
        {
            var json = JsonConvert.SerializeObject(body);
            var uri = new Uri(route);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri, data);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> Put(HttpClient client, string route, object body)
        {
            var json = JsonConvert.SerializeObject(body);
            var uri = new Uri(route);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(uri, data);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> Delete(HttpClient client, string route)
        {
            var uri = new Uri(route);
            var response = await client.DeleteAsync(uri);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> Get(HttpClient client, string route)
        {
            var uri = new Uri(route);
            var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
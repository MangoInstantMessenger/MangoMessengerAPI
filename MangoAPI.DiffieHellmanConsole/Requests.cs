using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole
{
    public static class HttpRequest
    {
        public static async Task<string> PostWithBodyAsync(HttpClient client, string route, object body)
        {
            var json = JsonConvert.SerializeObject(body);
            var uri = new Uri(route, UriKind.Absolute);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri, data);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        
        public static async Task<string> PostWithoutBodyAsync(HttpClient client, string route)
        {
            var uri = new Uri(route);
            var response = await client.PostAsync(uri, null!);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> PutWithBodyAsync(HttpClient client, string route, object body)
        {
            var json = JsonConvert.SerializeObject(body);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var uri = new Uri(route);
            var response = await client.PutAsync(uri, data);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> DeleteWithoutBodyAsync(HttpClient client, string route)
        {
            var uri = new Uri(route);
            var response = await client.DeleteAsync(uri);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        
        public static async Task<string> DeleteWithBodyAsync(HttpClient client, string route, object body)
        {
            var json = JsonContent.Create(body);

            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = json,
                Method = HttpMethod.Delete,
                RequestUri = new Uri(route)
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> GetAsync(HttpClient client, string route)
        {
            var uri = new Uri(route);
            var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
using System.Text;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class HttpRequestHelper
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
}

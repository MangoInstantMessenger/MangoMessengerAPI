using System.Text;
using System.Text.Json;

namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class HttpRequestHelper
{
    public static async Task<string> PostWithBodyAsync(HttpClient client, string route, object body)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var json = JsonSerializer.Serialize(body, options);
        var uri = new Uri(route, UriKind.Absolute);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(uri, data);
        _ = response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }

    public static async Task<string> PostWithoutBodyAsync(HttpClient client, string route)
    {
        var uri = new Uri(route);
        var response = await client.PostAsync(uri, null!);
        _ = response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }
}

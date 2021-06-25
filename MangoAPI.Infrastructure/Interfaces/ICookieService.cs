using Microsoft.AspNetCore.Http;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface ICookieService
    {
        string Get(HttpRequest request, string key);
        void Set(HttpResponse response, string key, string value, int? expireTime);
        void Remove(HttpResponse response, string key);
    }
}
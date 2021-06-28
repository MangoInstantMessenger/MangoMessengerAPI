using Microsoft.AspNetCore.Http;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface ICookieService
    {
        string Get(string key);
        void Set(string key, string value, int? expireDays);
        void Remove(string key);
    }
}
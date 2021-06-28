namespace MangoAPI.Application.Services
{
    public interface ICookieService
    {
        string Get(string key);
        void Set(string key, string value, int? expireDays);
        void Remove(string key);
    }
}
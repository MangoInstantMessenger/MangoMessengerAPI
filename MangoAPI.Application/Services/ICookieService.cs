namespace MangoAPI.Application.Services
{
    public interface ICookieService
    {
        string GetCookie(string key);
        void SetCookie(string key, string value, int? expireDays, string path, string domain);
        void RemoveCookie(string key);
    }
}
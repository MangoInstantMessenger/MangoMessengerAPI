using System;
using MangoAPI.Application.Services;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Infrastructure.Services
{
    public class CookieService : ICookieService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CookieService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public string GetCookie(string key) => _httpContextAccessor.HttpContext?.Request.Cookies[key];

        public void SetCookie(string key, string value, int? expireDays, string path, string domain)
        {
            var option = new CookieOptions
            {
                Path = path,
                Domain = domain,
                Expires = expireDays.HasValue
                    ? DateTime.Now.AddDays(expireDays.Value)
                    : DateTime.Now.AddMilliseconds(10),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None
            };

            _httpContextAccessor.HttpContext?.Response.Cookies.Append(key, value, option);  
        }

        public void RemoveCookie(string key) => _httpContextAccessor.HttpContext?.Response.Cookies.Delete(key);
    }
}
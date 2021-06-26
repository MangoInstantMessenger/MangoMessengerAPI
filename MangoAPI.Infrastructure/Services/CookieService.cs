using System;
using MangoAPI.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Infrastructure.Services
{
    public class CookieService : ICookieService
    {
        public string Get(HttpRequest request, string key)
        {
            return request.Cookies[key];
        }

        public void Set(HttpResponse response, string key, string value, int? expireDays)
        {
            var option = new CookieOptions
            {
                Expires = expireDays.HasValue
                    ? DateTime.Now.AddDays(expireDays.Value)
                    : DateTime.Now.AddMilliseconds(10)
            };

            response.Cookies.Append(key, value, option);  
        }

        public void Remove(HttpResponse response, string key)
        {
            response.Cookies.Delete(key);
        }
    }
}
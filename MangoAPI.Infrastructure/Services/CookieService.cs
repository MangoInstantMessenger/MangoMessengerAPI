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

        public void Set(HttpResponse response, string key, string value, int? expireTime)
        {
            var option = new CookieOptions
            {
                Expires = expireTime.HasValue
                    ? DateTime.Now.AddMinutes(expireTime.Value)
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
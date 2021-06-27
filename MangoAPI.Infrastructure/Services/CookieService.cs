﻿using System;
using MangoAPI.Infrastructure.Interfaces;
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
        
        public string Get(string key) => _httpContextAccessor.HttpContext.Request.Cookies[key];

        public void Set(string key, string value, int? expireDays)
        {
            var option = new CookieOptions
            {
                Expires = expireDays.HasValue
                    ? DateTime.Now.AddDays(expireDays.Value)
                    : DateTime.Now.AddMilliseconds(10),
                HttpOnly = true
            };

            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, option);  
        }

        public void Remove(string key)
        {
            _httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
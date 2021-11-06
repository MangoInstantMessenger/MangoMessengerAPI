using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace MangoAPI.Application.Services
{
    public class RequestValidationService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly List<string> _keys = new();

        public RequestValidationService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public bool ValidateRequest(HttpContext context, string requestName, int secondsDelay)
        {
            var userIp = context.Connection.RemoteIpAddress.MapToIPv4().ToString();
            var userAgent = context.Request.Headers["User-Agent"].ToString();
            var key = $"{requestName}_{userIp}_{userAgent}";
            var tryGet = _memoryCache.TryGetValue(key, out var request);

            if (!tryGet)
            {
                _keys.Add(key);
                _memoryCache.Set(key, DateTime.UtcNow);
                return true;
            }

            var requestAt = (DateTime) request;
            var currentDelay = DateTime.UtcNow - requestAt;
            var validRequest = currentDelay >= TimeSpan.FromSeconds(secondsDelay);

            if (validRequest)
            {
                _memoryCache.Remove(key);
                _memoryCache.Set(key, DateTime.UtcNow);
            }

            if (_keys.Count >= 100)
            {
                foreach (var item in _keys)
                {
                    _memoryCache.Remove(item);
                }
                
                _keys.Clear();
            }

            return validRequest;
        }
    }
}
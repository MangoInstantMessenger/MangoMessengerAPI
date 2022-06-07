using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Services;

public class CorrelationContext : ICorrelationContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CorrelationContext(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid GetUserId()
    {
        var context = _httpContextAccessor.HttpContext;

        var correlationContextUserId = context.User.FindFirstValue(JwtRegisteredClaimNames.Jti);

        var parsed = Guid.TryParse(correlationContextUserId, out var parsedUserId);

        if (!parsed)
        {
            throw new InvalidOperationException(
                $"User ID cannot be parsed. {nameof(correlationContextUserId)}.");
        }

        return parsedUserId;
    }

    public string GetUserName()
    {
        var context = _httpContextAccessor.HttpContext;

        var correlationUserName = context.User.FindFirstValue(JwtRegisteredClaimNames.Name);

        if (string.IsNullOrEmpty(correlationUserName))
        {
            throw new InvalidOperationException(
                $"User Name cannot be null or empty. {nameof(correlationUserName)}.");
        }

        return correlationUserName;
    }
}
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Services;

public class CorrelationContext : ICorrelationContext
{
    private readonly IHttpContextAccessor httpContextAccessor;

    public CorrelationContext(IHttpContextAccessor httpContextAccessor)
    {
        this.httpContextAccessor = httpContextAccessor;
    }

    public Guid GetUserId()
    {
        var context = httpContextAccessor.HttpContext;

        var correlationContextUserId = context?.User.FindFirstValue(JwtRegisteredClaimNames.Jti);

        var parsed = Guid.TryParse(correlationContextUserId, out var parsedUserId);

        return !parsed
            ? throw new InvalidOperationException(
                $"User ID cannot be parsed. {nameof(correlationContextUserId)}.")
            : parsedUserId;
    }
}
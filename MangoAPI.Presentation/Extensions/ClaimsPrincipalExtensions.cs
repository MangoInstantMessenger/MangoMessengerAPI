using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MangoAPI.Domain.Constants;

namespace MangoAPI.Presentation.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static Guid GetUserId(this ClaimsPrincipal principal)
    {
        return principal?.FindFirstValue(JwtRegisteredClaimNames.Jti).AsGuid() ??
               throw new InvalidOperationException("Claim not found");
    }
}
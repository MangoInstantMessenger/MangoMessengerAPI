namespace MangoAPI.Presentation.Extensions
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;

    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            return principal?.FindFirstValue(JwtRegisteredClaimNames.Jti) ??
                   throw new InvalidOperationException("Claim not found");
        }

        public static string GetRole(this ClaimsPrincipal principal)
        {
            return principal?.FindFirstValue(ClaimTypes.Role) ??
                   throw new InvalidOperationException("Claim not found");
        }
    }
}

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace MangoAPI.Infrastructure.Validators
{
    public class JwtSecurityTokenValidator : ISecurityTokenValidator
    {
        public bool CanReadToken(string securityToken) => true;

        public ClaimsPrincipal ValidateToken(string securityToken, TokenValidationParameters validationParameters,
            out SecurityToken validatedToken)
        {
            var tokenKey = Environment.GetEnvironmentVariable("MANGO_TOKEN_KEY");
            var issuer = Environment.GetEnvironmentVariable("MANGO_ISSUER");
            var audience = Environment.GetEnvironmentVariable("MANGO_AUDIENCE");
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey!));

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.ValidateToken(securityToken, new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidIssuer = issuer,
                ValidAudience = audience,
                IssuerSigningKey = signingKey
            }, out validatedToken);
        }

        public bool CanValidateToken => true;
        public int MaximumTokenSizeInBytes { get; set; }
    }
}
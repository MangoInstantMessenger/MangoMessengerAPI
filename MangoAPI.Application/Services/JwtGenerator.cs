using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Constants;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace MangoAPI.Application.Services
{
    public class JwtGenerator : IJwtGenerator
    {
        private readonly SymmetricSecurityKey _key;

        public JwtGenerator()
        {
            var tokenKey = EnvironmentConstants.MangoJwtSignKey;

            if (tokenKey == null)
            {
                throw new InvalidOperationException("Mango token key is null.");
            }

            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
        }

        public string GenerateJwtToken(Guid userId, List<string> roles)
        {
            var jwtLifetime = EnvironmentConstants.MangoJwtLifetime;

            if (jwtLifetime == null || !int.TryParse(jwtLifetime, out var jwtLifetimeParsed))
            {
                throw new InvalidOperationException("Jwt lifetime environmental variable error.");
            }

            return GenerateJwtToken(userId, jwtLifetimeParsed, roles);
        }

        public string GenerateJwtToken(Guid userId, int lifetimeMinutes, List<string> roles)
        {
            var claims = new List<Claim>
            {
                new (JwtRegisteredClaimNames.Jti, userId.ToString()),
            };

            roles.ForEach(x => claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, x)));

            var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(lifetimeMinutes),
                SigningCredentials = credentials,
                Issuer = EnvironmentConstants.MangoJwtIssuer,
                Audience = EnvironmentConstants.MangoJwtAudience,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

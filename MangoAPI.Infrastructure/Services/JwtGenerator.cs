using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace MangoAPI.Infrastructure.Services
{
    public class JwtGenerator : IJwtGenerator
    {
        private readonly SymmetricSecurityKey _key;

        public JwtGenerator()
        {
            var tokenKey = EnvironmentConstants.MangoTokenKey;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey!));
        }

        public string GenerateJwtToken(UserEntity userEntity)
        {
            return GenerateJwtToken(userEntity.Email, userEntity.Id);
        }

        public string GenerateJwtToken(string email,string userId)
        {
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, userId),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(ClaimTypes.NameIdentifier, userId)
            };
            
            var jwtLifetime = EnvironmentConstants.JwtLifeTime;

            if (jwtLifetime == null || !int.TryParse(jwtLifetime, out var jwtLifetimeParsed))
            {
                throw new InvalidOperationException("Jwt lifetime environmental variable error.");
            }
            
            var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddMinutes(jwtLifetimeParsed),
                SigningCredentials = credentials,
                Issuer = EnvironmentConstants.MangoIssuer,
                Audience = EnvironmentConstants.MangoAudience
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
        
        public RefreshTokenEntity GenerateRefreshToken(string userAgent, string fingerPrint, string ipAddress)
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                throw new InvalidOperationException("Refresh token lifetime environmental variable error.");
            }

            var randomBytes = new byte[64];
            new Random().NextBytes(randomBytes);
            rngCryptoServiceProvider.GetBytes(randomBytes);
            
            return new RefreshTokenEntity
            {
                Id = Guid.NewGuid().ToString(),
                RefreshToken = Convert.ToBase64String(randomBytes),
                UserAgent = userAgent,
                BrowserFingerprint = fingerPrint,
                IpAddress = ipAddress,
                Expires = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                Created = DateTime.UtcNow,
            };
        }
    }
}
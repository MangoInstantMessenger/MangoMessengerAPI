using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace MangoAPI.Infrastructure.Services
{
    public class JwtGenerator : IJwtGenerator
    {
        private readonly SymmetricSecurityKey _key;

        public JwtGenerator(IConfiguration config)
        {
            var tokenKey = Environment.GetEnvironmentVariable("MANGO_TOKEN_KEY");
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey!));
        }

        public string GenerateJwtToken(UserEntity userEntity)
        {
            return GenerateJwtToken(userEntity.Email);
        }

        public string GenerateJwtToken(string email)
        {
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.NameId, email)
            };
            
            var issuer = Environment.GetEnvironmentVariable("MANGO_ISSUER");
            var audience = Environment.GetEnvironmentVariable("MANGO_AUDIENCE");
            
            var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddMinutes(5),
                SigningCredentials = credentials,
                Issuer = issuer,
                Audience = audience
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
        
        public RefreshTokenEntity GenerateRefreshToken()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();

            var randomBytes = new byte[64];
            new Random().NextBytes(randomBytes);
            rngCryptoServiceProvider.GetBytes(randomBytes);
            
            return new RefreshTokenEntity
            {
                Token = Convert.ToBase64String(randomBytes),
                Expires = DateTime.UtcNow.AddDays(7),
                Created = DateTime.UtcNow,
            };
        }
    }
}
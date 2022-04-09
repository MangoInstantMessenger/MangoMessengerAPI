using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Constants;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace MangoAPI.Application.Services;

public class JwtGenerator : IJwtGenerator
{
    private readonly SymmetricSecurityKey _key;

    public JwtGenerator()
    {
        var tokenKey = EnvironmentConstants.MangoJwtSignKey;
        var encodedKey = Encoding.UTF8.GetBytes(tokenKey);
        _key = new SymmetricSecurityKey(encodedKey);
    }

    public string GenerateJwtToken(Guid userId)
    {
        return GenerateJwtToken(userId, EnvironmentConstants.MangoJwtLifetime);
    }

    private string GenerateJwtToken(Guid userId, int lifetimeMinutes)
    {
        var claims = new List<Claim>
        {
            new (JwtRegisteredClaimNames.Jti, userId.ToString()),
        };

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
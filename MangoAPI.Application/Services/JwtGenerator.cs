using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MangoAPI.Application.Interfaces;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace MangoAPI.Application.Services;

public class JwtGenerator : IJwtGenerator
{
    private readonly IJwtGeneratorSettings _jwtGeneratorSettings;
    private readonly SymmetricSecurityKey _key;

    public JwtGenerator(IJwtGeneratorSettings jwtGeneratorSettings)
    {
        _jwtGeneratorSettings = jwtGeneratorSettings;
        var encodedKey = Encoding.UTF8.GetBytes(_jwtGeneratorSettings.MangoJwtSignKey);
        _key = new SymmetricSecurityKey(encodedKey);
    }

    public string GenerateJwtToken(Guid userId)
    {
        return GenerateJwtToken(userId, _jwtGeneratorSettings.MangoJwtLifetime);
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
            Issuer = _jwtGeneratorSettings.MangoJwtIssuer,
            Audience = _jwtGeneratorSettings.MangoJwtAudience,
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
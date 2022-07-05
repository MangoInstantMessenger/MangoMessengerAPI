using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace MangoAPI.Application.Services;

public class JwtGenerator : IJwtGenerator
{
    private readonly IJwtGeneratorSettings jwtGeneratorSettings;
    private readonly SymmetricSecurityKey key;

    public JwtGenerator(IJwtGeneratorSettings jwtGeneratorSettings)
    {
        this.jwtGeneratorSettings = jwtGeneratorSettings;
        var encodedKey = Encoding.UTF8.GetBytes(this.jwtGeneratorSettings.MangoJwtSignKey);
        key = new SymmetricSecurityKey(encodedKey);
    }

    public string GenerateJwtToken(UserEntity userEntity)
    {
        return GenerateJwtToken(userEntity, jwtGeneratorSettings.MangoJwtLifetimeMinutes);
    }

    private string GenerateJwtToken(UserEntity userEntity, int lifetimeMinutes)
    {
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Jti, userEntity.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Name, userEntity.UserName),
        };

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddMinutes(lifetimeMinutes),
            SigningCredentials = credentials,
            Issuer = jwtGeneratorSettings.MangoJwtIssuer,
            Audience = jwtGeneratorSettings.MangoJwtAudience,
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}

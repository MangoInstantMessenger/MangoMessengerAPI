using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class JwtGeneratorSettings : IJwtGeneratorSettings
{
    public JwtGeneratorSettings(string mangoJwtIssuer, string mangoJwtAudience, string mangoJwtSignKey, int mangoJwtLifetime, int mangoRefreshTokenLifetime)
    {
        MangoJwtIssuer = mangoJwtIssuer;
        MangoJwtAudience = mangoJwtAudience;
        MangoJwtSignKey = mangoJwtSignKey;
        MangoJwtLifetime = mangoJwtLifetime;
        MangoRefreshTokenLifetime = mangoRefreshTokenLifetime;
    }
    
    public string MangoJwtIssuer { get; }
    public string MangoJwtAudience { get; }
    public string MangoJwtSignKey { get; }
    public int MangoJwtLifetime { get; }
    public int MangoRefreshTokenLifetime { get; }
}
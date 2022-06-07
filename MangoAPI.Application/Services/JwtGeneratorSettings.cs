using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class JwtGeneratorSettings : IJwtGeneratorSettings
{
    public JwtGeneratorSettings(
        string mangoJwtIssuer,
        string mangoJwtAudience,
        string mangoJwtSignKey,
        int mangoJwtLifetimeMinutes,
        int mangoRefreshTokenLifetimeDays)
    {
        MangoJwtIssuer = mangoJwtIssuer;
        MangoJwtAudience = mangoJwtAudience;
        MangoJwtSignKey = mangoJwtSignKey;
        MangoJwtLifetimeMinutes = mangoJwtLifetimeMinutes;
        MangoRefreshTokenLifetimeDays = mangoRefreshTokenLifetimeDays;
    }

    public string MangoJwtIssuer { get; }
    public string MangoJwtAudience { get; }
    public string MangoJwtSignKey { get; }
    public int MangoJwtLifetimeMinutes { get; }
    public int MangoRefreshTokenLifetimeDays { get; }
}
namespace MangoAPI.Application.Interfaces;

public interface IJwtGeneratorSettings
{
    string MangoJwtIssuer { get; }
    string MangoJwtAudience { get; }
    string MangoJwtSignKey { get; }
    int MangoJwtLifetimeMinutes { get; }
    int MangoRefreshTokenLifetimeDays { get; }
}
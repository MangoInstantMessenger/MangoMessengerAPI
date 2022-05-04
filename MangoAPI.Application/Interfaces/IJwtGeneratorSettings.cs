namespace MangoAPI.Application.Interfaces;

public interface IJwtGeneratorSettings
{
    string MangoJwtIssuer { get; }
    string MangoJwtAudience { get; }
    string MangoJwtSignKey { get; }
    int MangoJwtLifetime { get; }
    int MangoRefreshTokenLifetime { get; }
}
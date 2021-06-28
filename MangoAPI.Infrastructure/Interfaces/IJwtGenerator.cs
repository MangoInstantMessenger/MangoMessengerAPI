using MangoAPI.Domain.Entities;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface IJwtGenerator
    {
        string GenerateJwtToken(UserEntity userEntity);
        string GenerateJwtToken(string email,string userId);
        RefreshTokenEntity GenerateRefreshToken(string userAgent, string fingerPrint, string ipAddress);
    }
}
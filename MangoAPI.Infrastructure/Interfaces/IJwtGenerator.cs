using MangoAPI.Domain.Entities;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
        string CreateToken(string email);
        RefreshTokenEntity GenerateRefreshToken(string ipAddress);
    }
}
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Services
{
    public interface IJwtGenerator
    {
        string GenerateJwtToken(UserEntity userEntity);
        RefreshTokenEntity GenerateRefreshToken();
    }
}
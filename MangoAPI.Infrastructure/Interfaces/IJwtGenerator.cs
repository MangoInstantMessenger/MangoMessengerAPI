using MangoAPI.Domain.Entities;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
    }
}
using MangoAPI.Domain.Entities;

namespace MangoAPI.Domain
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
    }
}
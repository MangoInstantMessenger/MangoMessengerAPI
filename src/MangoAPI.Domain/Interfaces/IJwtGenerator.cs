using MangoAPI.Domain.Entities;

namespace MangoAPI.Domain.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
        string CreateToken(string email);
    }
}
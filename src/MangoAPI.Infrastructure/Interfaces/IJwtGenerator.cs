using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
        string CreateToken(string email);
    }
}
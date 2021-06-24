using Mango.Auth.Domain;

namespace MangoAPI.WebApp.Infrastructure
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
    }
}
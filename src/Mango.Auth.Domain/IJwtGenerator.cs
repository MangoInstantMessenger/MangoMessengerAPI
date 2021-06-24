namespace Mango.Auth.Domain
{
    public interface IJwtGenerator
    {
        string CreateToken(UserEntity userEntity);
    }
}
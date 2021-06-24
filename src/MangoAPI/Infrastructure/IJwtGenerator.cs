using MangoAPI.Data.Entities;

namespace MangoAPI.Infrastructure
{
    public interface IJwtGenerator
    {
        string CreateToken(AppUser user);
    }
}
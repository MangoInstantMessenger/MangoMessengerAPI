namespace MangoAPI.Application.Interfaces
{
    using System.Collections.Generic;
    using MangoAPI.Domain.Entities;

    public interface IJwtGenerator
    {
        string GenerateJwtToken(UserEntity userEntity, List<string> roles);
    }
}

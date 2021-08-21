namespace MangoAPI.Application.Interfaces
{
    using System.Collections.Generic;
    using Domain.Entities;

    public interface IJwtGenerator
    {
        string GenerateJwtToken(UserEntity userEntity, List<string> roles);
    }
}

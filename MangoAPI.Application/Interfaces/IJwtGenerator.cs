using System.Collections.Generic;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Interfaces
{
    public interface IJwtGenerator
    {
        string GenerateJwtToken(UserEntity userEntity, List<string> roles);
    }
}

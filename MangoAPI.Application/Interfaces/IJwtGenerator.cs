using System;
using System.Collections.Generic;

namespace MangoAPI.Application.Interfaces
{
    public interface IJwtGenerator
    {
        string GenerateJwtToken(Guid userId);

        string GenerateJwtToken(Guid userId, int lifetimeMinutes);
    }
}
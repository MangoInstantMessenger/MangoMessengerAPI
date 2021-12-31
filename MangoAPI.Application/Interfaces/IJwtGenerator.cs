using System;

namespace MangoAPI.Application.Interfaces
{
    public interface IJwtGenerator
    {
        string GenerateJwtToken(Guid userId);
    }
}
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.Services
{
    public class PasswordHashService : PasswordHasher<UserEntity>
    {
        public override string HashPassword(UserEntity user, string password)
        {
            var hash = base.HashPassword(user, password);
            user.PasswordHash = hash;

            return hash; 
        }
    }
}
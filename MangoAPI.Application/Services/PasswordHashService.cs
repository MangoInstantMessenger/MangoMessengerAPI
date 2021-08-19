namespace MangoAPI.Application.Services
{
    using MangoAPI.Domain.Entities;
    using Microsoft.AspNetCore.Identity;

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

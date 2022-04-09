using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Services;

public class PasswordHashService : PasswordHasher<UserEntity>
{
    public override string HashPassword(UserEntity user, string password)
    {
        //This looks strange a bit. I wanna delete it or make it like an extension method.
        user.PasswordHash = base.HashPassword(user, password);
        
        return user.PasswordHash;
    }
}
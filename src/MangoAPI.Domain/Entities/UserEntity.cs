using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    public sealed class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    public class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
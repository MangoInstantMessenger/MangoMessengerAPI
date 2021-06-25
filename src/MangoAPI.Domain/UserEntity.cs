using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain
{
    public class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
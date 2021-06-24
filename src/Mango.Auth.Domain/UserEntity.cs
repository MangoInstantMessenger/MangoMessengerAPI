using Microsoft.AspNetCore.Identity;

namespace Mango.Auth.Domain
{
    public class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
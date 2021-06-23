using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    public sealed class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
    }
}
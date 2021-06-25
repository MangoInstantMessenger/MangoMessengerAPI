using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    public class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<RefreshTokenEntity> TokenEntities { get; set; }
    }
}
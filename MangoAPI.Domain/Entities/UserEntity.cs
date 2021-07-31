using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    public sealed class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
        public string? Image { get; set; }
        public string? Bio { get; set; }
        public int? ConfirmationCode { get; set; }
        public bool Verified => EmailConfirmed || PhoneNumberConfirmed;

        public ICollection<RefreshTokenEntity> RefreshTokens { get; set; }
        public ICollection<MessageEntity> Messages { get; set; }
        public ICollection<UserChatEntity> UserChats { get; set; }
        public UserInformationEntity UserInformation { get; set; }
        public ICollection<UserContactEntity> Contacts { get; set; }
    }
}
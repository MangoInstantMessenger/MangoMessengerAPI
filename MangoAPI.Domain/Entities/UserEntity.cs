namespace MangoAPI.Domain.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public sealed class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }

        public string? Image { get; set; }

        public string? Bio { get; set; }

        public int? ConfirmationCode { get; set; }

        public ICollection<SessionEntity> Sessions { get; set; }

        public ICollection<MessageEntity> Messages { get; set; }

        public ICollection<UserChatEntity> UserChats { get; set; }

        public UserInformationEntity UserInformation { get; set; }

        public ICollection<UserContactEntity> Contacts { get; set; }
    }
}
#nullable enable

namespace MangoAPI.Domain.Entities
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public sealed class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; } = null!;

        public string? Image { get; set; }

        public string? Bio { get; set; }

        public int? ConfirmationCode { get; set; }

        public ICollection<SessionEntity> Sessions { get; set; } = null!;

        public ICollection<MessageEntity> Messages { get; set; } = null!;

        public ICollection<UserChatEntity> UserChats { get; set; } = null!;

        public UserInformationEntity UserInformation { get; set; } = null!;

        public ICollection<UserContactEntity> Contacts { get; set; } = null!;
    }
}

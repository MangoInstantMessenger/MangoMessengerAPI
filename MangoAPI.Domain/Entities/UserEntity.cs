using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MangoAPI.Domain.Entities
{
    public sealed class UserEntity : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }

        public string Image { get; set; }

        public string Bio { get; set; }

        public int? PhoneCode { get; set; }

        public Guid EmailCode { get; set; }

        public int PublicKey { get; set; }

        public ICollection<PasswordRestoreRequestEntity> PasswordRestoreRequests { get; set; }

        public ICollection<SessionEntity> Sessions { get; set; }

        public ICollection<MessageEntity> Messages { get; set; }

        public ICollection<UserChatEntity> UserChats { get; set; }

        public UserInformationEntity UserInformation { get; set; }

        public ICollection<UserContactEntity> Contacts { get; set; }
    }
}
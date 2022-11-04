using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities;

public sealed class UserEntity : IdentityUser<Guid>
{
    public string DisplayName { get; set; }

    public string Image { get; set; }

    public string Bio { get; set; }

    public Guid EmailCode { get; set; }

    public DisplayNameColour DisplayNameColour { get; set; }

    public ICollection<PasswordRestoreRequestEntity> PasswordRestoreRequests { get; set; }

    public ICollection<SessionEntity> Sessions { get; set; }

    public ICollection<MessageEntity> Messages { get; set; }

    public ICollection<UserChatEntity> UserChats { get; set; }

    public UserInformationEntity UserInformation { get; set; }

    public ICollection<UserContactEntity> Contacts { get; set; }

    public ICollection<DocumentEntity> Documents { get; set; }
}

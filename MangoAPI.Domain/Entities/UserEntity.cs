using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    class amogus : IdentityUser<string>
    {
    }

    public class UserEntity : IdentityUser
    {
        // public UserEntity()
        // {
        //     
        // }
        
        private UserEntity(string phoneNumber, string displayName,
                           string userName, string email, 
                           int? confirmationCode)
        {
            PhoneNumber = phoneNumber;
            DisplayName = displayName;
            UserName = userName;
            Email = email;
            ConfirmationCode = confirmationCode;
        }
        
        private UserEntity(string phoneNumber, string displayName,
            string userName, string email)
        {
            PhoneNumber = phoneNumber;
            DisplayName = displayName;
            UserName = userName;
            Email = email;
        }

        public string DisplayName { get; }
        public string Image { get; }
        public string Bio { get;}
        public int? ConfirmationCode { get; }
        public bool Verified => EmailConfirmed || PhoneNumberConfirmed;

        public static UserEntity Create(string phoneNumber, string displayName,
            string userName, string email,
            int? confirmationCode) =>
            new(phoneNumber, displayName, userName, email, confirmationCode);
        
        public static UserEntity Create(string phoneNumber, string displayName,
            string userName, string email) => 
            new(phoneNumber, displayName, userName, email);

        public void SetPhoneNumberVerified() =>
            PhoneNumberConfirmed = true;

        public virtual ICollection<RefreshTokenEntity> RefreshTokens { get; set; }
        public virtual ICollection<MessageEntity> Messages { get; set; }
        public virtual ICollection<UserChatEntity> UserChats { get; set;  }

    }
}
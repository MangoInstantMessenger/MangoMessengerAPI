using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Contacts
{
    public record GetContactsResponse : ContactsResponseBase<GetContactsResponse>
    {
        public List<User> Contacts { get; set; }

        public static GetContactsResponse FromSuccess(IEnumerable<UserContactEntity> contacts) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Contacts = contacts
                .Select(contact => 
                    new User()
                    {
                        Username = contact.User.UserName,
                        DisplayName =  contact.User.DisplayName,
                        Image = contact.User.Image,
                        Bio = contact.User.Bio
                    }
                ).ToList()
        };

    }
}
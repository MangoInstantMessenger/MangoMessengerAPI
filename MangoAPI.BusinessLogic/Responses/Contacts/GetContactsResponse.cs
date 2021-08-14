using System.Collections.Generic;
using System.Linq;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.Responses.Contacts
{
    public record GetContactsResponse : ContactsResponseBase<GetContactsResponse>
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public List<User> Contacts { get; init; }

        public static GetContactsResponse FromSuccess(IEnumerable<UserEntity> contacts) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Contacts = contacts
                .Select(contact =>
                    new User
                    {
                        Username = contact.UserName,
                        DisplayName = contact.DisplayName,
                        Image = contact.Image,
                        Bio = contact.Bio
                    }).ToList()
        };
    }
}
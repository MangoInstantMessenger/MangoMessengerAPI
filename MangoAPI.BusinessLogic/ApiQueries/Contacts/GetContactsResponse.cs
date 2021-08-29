namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record GetContactsResponse : ContactsResponseBase<GetContactsResponse>
    {
        public List<Contact> Contacts { get; init; }

        public static GetContactsResponse FromSuccess(IEnumerable<UserEntity> contacts)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Contacts = contacts
                    .Select(userEntity =>
                        new Contact
                        {
                            UserId = userEntity.Id,
                            DisplayName = userEntity.DisplayName,
                            Address = userEntity.UserInformation.Address,
                            Bio = userEntity.Bio,
                            IsContact = true,
                        }).ToList(),
            };
        }
    }
}

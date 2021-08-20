namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using System.Collections.Generic;
    using System.Linq;
    using MangoAPI.BusinessLogic.Models;
    using MangoAPI.BusinessLogic.Responses;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;

    public record GetContactsResponse : ContactsResponseBase<GetContactsResponse>
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
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
                            DisplayName = userEntity.DisplayName,
                            Address = userEntity.UserInformation.Address,
                        }).ToList(),
            };
        }
    }
}

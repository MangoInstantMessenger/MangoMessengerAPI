namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using Domain.Constants;
    using Models;
    using Responses;
    using System.Collections.Generic;

    public record SearchContactByDisplayNameResponse : ResponseBase<SearchContactByDisplayNameResponse>
    {
        public List<Contact> Contacts { get; init; }

        public static SearchContactByDisplayNameResponse FromSuccess(List<Contact> contacts)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Contacts = contacts,
            };
        }
    }
}
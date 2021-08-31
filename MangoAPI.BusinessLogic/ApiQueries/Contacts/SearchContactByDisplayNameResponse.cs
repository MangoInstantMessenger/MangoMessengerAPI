using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
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
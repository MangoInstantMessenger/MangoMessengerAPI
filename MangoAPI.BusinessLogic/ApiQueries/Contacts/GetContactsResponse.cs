using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using System.Collections.Generic;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public record GetContactsResponse : ResponseBase
{
    public List<Contact> Contacts { get; init; }

    public static GetContactsResponse FromSuccess(List<Contact> contacts)
    {
        return new GetContactsResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Contacts = contacts,
        };
    }
}
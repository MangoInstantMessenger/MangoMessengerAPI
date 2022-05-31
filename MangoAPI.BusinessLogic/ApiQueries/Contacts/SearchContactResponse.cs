using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public record SearchContactResponse : ResponseBase
{
    public List<Contact> Contacts { get; init; }

    public static SearchContactResponse FromSuccess(List<Contact> contacts)
    {
        return new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Contacts = contacts
        };
    }
}
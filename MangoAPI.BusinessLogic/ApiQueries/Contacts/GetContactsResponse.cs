using System.Collections.Generic;
using System.Linq;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record GetContactsResponse : ResponseBase<GetContactsResponse>
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
                            PictureUrl = StringService.GetDocumentUrl(userEntity.Image),
                        }).ToList(),
            };
        }
    }
}

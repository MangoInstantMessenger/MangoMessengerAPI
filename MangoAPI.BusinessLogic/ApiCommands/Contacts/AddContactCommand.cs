using MangoAPI.DTO.Responses.Contacts;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Contacts
{
    public record AddContactCommand : IRequest<AddContactResponse>
    {
        public string ContactId { get; init; }
        public string UserId { get; init; }
    }
}
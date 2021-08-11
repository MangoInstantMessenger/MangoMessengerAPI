using MangoAPI.BusinessLogic.Responses.Contacts;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public record AddContactCommand : IRequest<AddContactResponse>
    {
        public string ContactId { get; init; }
        public string UserId { get; init; }
    }
}
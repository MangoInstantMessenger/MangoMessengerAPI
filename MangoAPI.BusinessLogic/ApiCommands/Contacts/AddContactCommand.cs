using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public record AddContactCommand : IRequest<ResponseBase>
    {
        public string ContactId { get; init; }
        public string UserId { get; init; }
    }
}

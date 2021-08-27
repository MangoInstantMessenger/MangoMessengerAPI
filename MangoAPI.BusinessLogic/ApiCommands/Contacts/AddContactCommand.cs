namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    using MediatR;

    public record AddContactCommand : IRequest<AddContactResponse>
    {
        public string ContactId { get; init; }
        public string UserId { get; init; }
    }
}

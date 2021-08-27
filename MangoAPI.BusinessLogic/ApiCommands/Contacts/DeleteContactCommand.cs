using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class DeleteContactCommand : IRequest<DeleteContactResponse>
    {
        public string UserId { get; set; }
        public string ContactId { get; set; }
    }
}
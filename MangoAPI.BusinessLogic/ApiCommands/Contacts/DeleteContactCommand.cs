using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class DeleteContactCommand : IRequest<ResponseBase>
    {
        public string UserId { get; set; }
        public string ContactId { get; set; }
    }
}
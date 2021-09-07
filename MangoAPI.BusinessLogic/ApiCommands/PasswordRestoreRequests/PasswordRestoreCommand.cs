using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreCommand : IRequest<ResponseBase>
    {
        public string RequestId { get; set; }
        public string NewPassword { get; set; }
        public string RepeatPassword { get; set; }
    }
}
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreCommand : IRequest<ResponseBase>
    {
        public string RequestId { get; init; }
        public string NewPassword { get; init; }
        public string RepeatPassword { get; init; }
    }
}
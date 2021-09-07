using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record RestorePasswordCommand : IRequest<RestorePasswordResponse>
    {
        public string EmailOrPhone { get; set; }
    }
}
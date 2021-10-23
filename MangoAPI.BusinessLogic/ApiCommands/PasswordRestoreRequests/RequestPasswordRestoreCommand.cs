using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record RequestPasswordRestoreCommand : IRequest<GenericResponse<ResponseBase>>
    {
        public string EmailOrPhone { get; init; }
    }
}
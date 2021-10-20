using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record RequestPasswordRestoreCommand : IRequest<GenericResponse<ResponseBase,ErrorResponse>>
    {
        public string EmailOrPhone { get; init; }
    }
}
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LogoutAllCommand : IRequest<ResponseBase>
    {
        public string UserId { get; init; }
    }
}

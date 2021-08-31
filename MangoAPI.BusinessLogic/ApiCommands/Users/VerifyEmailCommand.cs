using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyEmailCommand : IRequest<ResponseBase>
    {
        public string Email { get; init; }
        public string UserId { get; init; }
    }
}
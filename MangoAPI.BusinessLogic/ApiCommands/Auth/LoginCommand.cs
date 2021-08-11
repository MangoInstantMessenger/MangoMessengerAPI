using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record LoginCommand : IRequest<LoginResponse>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
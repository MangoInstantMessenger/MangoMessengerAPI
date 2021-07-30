using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record VerifyPhoneCommand : IRequest<VerifyPhoneResponse>
    {
        public int ConfirmationCode { get; init; }
        public string UserId { get; init; }
    }
}
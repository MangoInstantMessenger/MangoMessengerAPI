using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyPhoneCommand : IRequest<VerifyPhoneResponse>
    {
        public int ConfirmationCode { get; init; }
        public string UserId { get; init; }
    }
}

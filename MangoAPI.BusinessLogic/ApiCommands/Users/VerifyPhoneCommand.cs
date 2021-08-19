namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using MediatR;

    public record VerifyPhoneCommand : IRequest<VerifyPhoneResponse>
    {
        public int ConfirmationCode { get; init; }
        public string UserId { get; init; }
    }
}

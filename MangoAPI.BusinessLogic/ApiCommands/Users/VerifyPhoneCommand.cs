using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyPhoneCommand : IRequest<ResponseBase>
    {
        public int ConfirmationCode { get; init; }
        public string UserId { get; init; }
    }
}

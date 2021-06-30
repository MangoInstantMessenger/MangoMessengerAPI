using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class VerifyPhoneCommand : IRequest<VerifyPhoneResponse>
    {
        public string ValidationCode { get; set; }
    }
}
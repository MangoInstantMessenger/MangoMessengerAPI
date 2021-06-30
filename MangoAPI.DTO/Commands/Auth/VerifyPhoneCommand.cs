using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class VerifyPhoneCodeCommand : IRequest<VerifyPhoneCodeResponse>
    {
        public string ValidationCode { get; set; }
    }
}
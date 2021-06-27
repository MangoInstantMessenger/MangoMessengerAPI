using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class ConfirmRegisterCommand : IRequest<ConfirmRegisterResponse>
    {
        public string ValidationCode { get; set; }
    }
}
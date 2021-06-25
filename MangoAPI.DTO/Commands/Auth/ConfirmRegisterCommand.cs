using MangoAPI.DTO.Responses;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class ConfirmRegisterCommand : IRequest<ConfirmRegisterResponse>
    {
        public string Guid { get; set; }
    }
}
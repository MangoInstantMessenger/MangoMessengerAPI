using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record ChangePasswordCommand : IRequest<GenericResponse<ResponseBase,ErrorResponse>>
    {
        public Guid UserId { get; set; }
        public string CurrentPassword { get; init; }
        public string NewPassword { get; init; }
    }
}

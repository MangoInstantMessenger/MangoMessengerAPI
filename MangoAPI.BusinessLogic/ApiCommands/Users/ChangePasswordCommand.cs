using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record ChangePasswordCommand : IRequest<ResponseBase>
    {
        public Guid UserId { get; init; }
        public string CurrentPassword { get; init; }
        public string NewPassword { get; init; }
    }
}

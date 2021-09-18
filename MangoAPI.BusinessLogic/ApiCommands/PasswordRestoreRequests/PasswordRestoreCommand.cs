using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreCommand : IRequest<ResponseBase>
    {
        public Guid RequestId { get; init; }
        public string NewPassword { get; init; }
        public string RepeatPassword { get; init; }
    }
}
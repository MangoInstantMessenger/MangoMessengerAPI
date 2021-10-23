using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreCommand : IRequest<GenericResponse<ResponseBase>>
    {
        public Guid RequestId { get; init; }
        public string NewPassword { get; init; }
        public string RepeatPassword { get; init; }
    }
}
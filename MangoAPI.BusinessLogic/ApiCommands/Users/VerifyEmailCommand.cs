using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyEmailCommand : IRequest<GenericResponse<ResponseBase,ErrorResponse>>
    {
        public string Email { get; init; }
        public Guid EmailCode { get; init; }
    }
}
using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyPhoneCommand : IRequest<GenericResponse<ResponseBase,ErrorResponse>>
    {
        public int ConfirmationCode { get; init; }
        public Guid UserId { get; init; }
    }
}

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LogoutCommand : IRequest<Result<ResponseBase>>
    {
        public Guid RefreshToken { get; init; }
    }
}

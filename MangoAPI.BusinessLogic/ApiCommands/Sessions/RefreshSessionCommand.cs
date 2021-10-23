using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record RefreshSessionCommand : IRequest<GenericResponse<TokensResponse>>
    {
        public Guid RefreshToken { get; init; }
    }
}
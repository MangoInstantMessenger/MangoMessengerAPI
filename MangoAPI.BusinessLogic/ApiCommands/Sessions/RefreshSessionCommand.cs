using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record RefreshSessionCommand(Guid RefreshToken)
    : IRequest<Result<TokensResponse>>;
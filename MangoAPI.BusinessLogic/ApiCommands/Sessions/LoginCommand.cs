using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LoginCommand(string Username, string Password)
    : IRequest<Result<TokensResponse>>;
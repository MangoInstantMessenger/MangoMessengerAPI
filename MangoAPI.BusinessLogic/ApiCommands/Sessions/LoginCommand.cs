using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LoginCommand(string Email, string Password)
    : IRequest<Result<TokensResponse>>;

using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record RegisterCommand(
        string Username,
        string Password)
    : IRequest<Result<TokensResponse>>;

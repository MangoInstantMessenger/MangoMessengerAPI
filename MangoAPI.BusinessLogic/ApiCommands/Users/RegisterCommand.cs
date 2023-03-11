using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record RegisterCommand(
        string Email,
        string DisplayName,
        string Password)
    : IRequest<Result<TokensResponse>>;

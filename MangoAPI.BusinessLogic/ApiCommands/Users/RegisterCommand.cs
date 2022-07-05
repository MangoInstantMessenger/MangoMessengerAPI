using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record RegisterCommand(
        string Email,
        string DisplayName,
        string Password,
        bool TermsAccepted)
    : IRequest<Result<RegisterResponse>>;

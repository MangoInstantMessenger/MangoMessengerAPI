using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record RegisterCommand : IRequest<Result<RegisterResponse>>
{
    public string Email { get; init; }
    public string DisplayName { get; init; }
    public string Password { get; init; }
    public bool TermsAccepted { get; init; }

    public RegisterCommand()
    {
    }

    public RegisterCommand(string email, string displayName, string password, bool termsAccepted)
    {
        Email = email;
        DisplayName = displayName;
        Password = password;
        TermsAccepted = termsAccepted;
    }
}
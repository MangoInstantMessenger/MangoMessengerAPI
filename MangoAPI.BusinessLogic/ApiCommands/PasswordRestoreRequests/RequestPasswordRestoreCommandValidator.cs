using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class RequestPasswordRestoreCommandValidator : AbstractValidator<RequestPasswordRestoreCommand>
{
    public RequestPasswordRestoreCommandValidator()
    {
        _ = RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 300);
    }
}
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserAccountInfoCommandValidator : AbstractValidator<UpdateUserAccountInfoCommand>
{
    public UpdateUserAccountInfoCommandValidator()
    {
        _ = RuleFor(x => x.Address)
            .Cascade(CascadeMode.Stop)
            .Length(0, 120);

        _ = RuleFor(x => x.Bio)
            .Cascade(CascadeMode.Stop)
            .Length(0, 120);

        _ = RuleFor(x => x.DisplayName)
            .Cascade(CascadeMode.Stop)
            .Length(1, 40);

        _ = RuleFor(x => x.UserId).NotEmpty();

        _ = RuleFor(x => x.Username)
            .Cascade(CascadeMode.Stop)
            .Length(0, 40);

        _ = RuleFor(x => x.Website)
            .Cascade(CascadeMode.Stop)
            .Length(0, 30);
    }
}
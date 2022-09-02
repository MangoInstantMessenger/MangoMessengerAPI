using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserAccountInfoCommandValidator : AbstractValidator<UpdateUserAccountInfoCommand>
{
    public UpdateUserAccountInfoCommandValidator()
    {
        RuleFor(x => x.Address)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 120);

        RuleFor(x => x.Bio)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 120);

        RuleFor(x => x.BirthdayDate)
            .Cascade(CascadeMode.Stop)
            .NotNull();

        RuleFor(x => x.DisplayName)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 40);

        RuleFor(x => x.UserId).NotEmpty();

        RuleFor(x => x.Username)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 40);

        RuleFor(x => x.Website)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 30);
    }
}
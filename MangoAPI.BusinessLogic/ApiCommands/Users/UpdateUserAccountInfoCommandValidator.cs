using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserAccountInfoCommandValidator : AbstractValidator<UpdateUserAccountInfoCommand>
{
    public UpdateUserAccountInfoCommandValidator()
    {
        RuleFor(x => x.Address)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 120);

        RuleFor(x => x.Bio).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 120);

        RuleFor(x => x.BirthdayDate)
            .Cascade(CascadeMode.Stop)
            .NotEmpty();

        RuleFor(x => x.DisplayName)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 40);

        RuleFor(x => x.UserId).NotEmpty();

        RuleFor(x => x.Username)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 40);

        RuleFor(x => x.Website)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 30);
    }
}
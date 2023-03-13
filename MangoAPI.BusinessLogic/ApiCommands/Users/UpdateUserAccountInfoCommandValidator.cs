using FluentValidation;
using System.Linq;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserAccountInfoCommandValidator : AbstractValidator<UpdateUserAccountInfoCommand>
{
    public UpdateUserAccountInfoCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        
        RuleFor(x => x.Address)
            .Cascade(CascadeMode.Stop)
            .Length(0, 50);

        RuleFor(x => x.Bio)
            .Cascade(CascadeMode.Stop)
            .Length(0, 120);

        RuleFor(x => x.DisplayName)
            .Cascade(CascadeMode.Stop)
            .Length(1, 50);

        RuleFor(x => x.Username)
            .Cascade(CascadeMode.Stop)
            .Must(username => username.All(char.IsLetterOrDigit))
            .NotEmpty()
            .Length(5, 50);

        RuleFor(x => x.Website)
            .Cascade(CascadeMode.Stop)
            .Length(0, 30);
    }
}
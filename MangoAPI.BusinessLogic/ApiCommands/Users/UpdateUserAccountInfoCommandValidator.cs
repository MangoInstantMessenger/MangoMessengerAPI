using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
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
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.UserId).NotEmpty();

            RuleFor(x => x.Username)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.Website)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 30);
        }
    }
}
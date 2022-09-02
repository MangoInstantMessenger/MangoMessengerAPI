using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserSocialInformationCommandValidator : AbstractValidator<UpdateUserSocialInformationCommand>
{
    public UpdateUserSocialInformationCommandValidator()
    {
        RuleFor(x => x.Facebook)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 30);

        RuleFor(x => x.Instagram)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 30);

        RuleFor(x => x.LinkedIn)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 30);

        RuleFor(x => x.Twitter)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .Length(0, 30);

        RuleFor(x => x.UserId).NotEmpty();
    }
}
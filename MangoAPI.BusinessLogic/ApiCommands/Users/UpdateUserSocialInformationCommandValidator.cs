using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserSocialInformationCommandValidator : AbstractValidator<UpdateUserSocialInformationCommand>
{
    public UpdateUserSocialInformationCommandValidator()
    {
        _ = RuleFor(x => x.Facebook)
            .Cascade(CascadeMode.Stop)
            .Length(0, 30);

        _ = RuleFor(x => x.Instagram)
            .Cascade(CascadeMode.Stop)
            .Length(0, 30);

        _ = RuleFor(x => x.LinkedIn)
            .Cascade(CascadeMode.Stop)
            .Length(0, 30);

        _ = RuleFor(x => x.Twitter)
            .Cascade(CascadeMode.Stop)
            .Length(0, 30);

        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}
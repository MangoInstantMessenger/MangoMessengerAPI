using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChannelCommandValidator : AbstractValidator<CreateChannelCommand>
{
    public CreateChannelCommandValidator()
    {
        _ = RuleFor(x => x.ChannelTitle)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 50);

        _ = RuleFor(x => x.ChannelDescription)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 100);
    }
}

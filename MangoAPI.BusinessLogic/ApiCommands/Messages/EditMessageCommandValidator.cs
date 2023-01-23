using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class EditMessageCommandValidator : AbstractValidator<EditMessageCommand>
{
    public EditMessageCommandValidator()
    {
        _ = RuleFor(x => x.ModifiedText)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 300);

        _ = RuleFor(x => x.MessageId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}
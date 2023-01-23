using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class CreateChatCommandValidator : AbstractValidator<CreateChatCommand>
{
    public CreateChatCommandValidator()
    {
        _ = RuleFor(x => x.PartnerId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}
using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class SendMessageCommandValidator : AbstractValidator<SendMessageCommand>
    {
        public SendMessageCommandValidator()
        {
            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SendMessageCommand: Chat Id cannot be parsed.");

            RuleFor(x => x.MessageText)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SendMessageCommand: User Id cannot be parsed.");
        }
    }
}

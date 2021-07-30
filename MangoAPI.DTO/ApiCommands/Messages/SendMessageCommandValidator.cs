using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public class SendMessageCommandValidator : AbstractValidator<SendMessageCommand>
    {
        public SendMessageCommandValidator()
        {
            RuleFor(x => x.ChatId).NotNull().NotEmpty();
            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SendMessageCommand: Chat Id cannot be parsed.");
            
            RuleFor(x => x.MessageText).NotNull().NotEmpty();
            RuleFor(x => x.MessageText).MaximumLength(300);
            
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SendMessageCommand: User Id cannot be parsed.");
        }
    }
}
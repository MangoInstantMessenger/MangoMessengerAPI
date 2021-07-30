using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public class EditMessageCommandValidator : AbstractValidator<EditMessageCommand>
    {
        public EditMessageCommandValidator()
        {
            RuleFor(x => x.MessageId).NotNull().NotEmpty();
            RuleFor(x => x.MessageId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("EditMessageCommand: Message Id cannot be parsed.");
            
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("EditMessageCommand: User Id cannot be parsed.");
            
            RuleFor(x => x.ModifiedText).NotNull().NotEmpty();
            RuleFor(x => x.ModifiedText).MaximumLength(300);
        }
    }
}
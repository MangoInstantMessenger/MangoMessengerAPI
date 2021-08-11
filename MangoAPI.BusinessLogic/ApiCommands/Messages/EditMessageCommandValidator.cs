using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class EditMessageCommandValidator : AbstractValidator<EditMessageCommand>
    {
        public EditMessageCommandValidator()
        {
            RuleFor(x => x.MessageId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.MessageId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("EditMessageCommand: Message Id cannot be parsed.");
            
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("EditMessageCommand: User Id cannot be parsed.");
            
            RuleFor(x => x.ModifiedText)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.ModifiedText).MaximumLength(300);
        }
    }
}
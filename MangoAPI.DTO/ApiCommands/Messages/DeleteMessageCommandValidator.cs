using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public class DeleteMessageCommandValidator : AbstractValidator<DeleteMessageCommand>
    {
        public DeleteMessageCommandValidator()
        {
            RuleFor(x => x.MessageId).NotNull().NotEmpty();
            RuleFor(x => x.MessageId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("DeleteMessageCommand: Message Id cannot be parsed.");
            
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("DeleteMessageCommand: User Id cannot be parsed.");
        }
    }
}
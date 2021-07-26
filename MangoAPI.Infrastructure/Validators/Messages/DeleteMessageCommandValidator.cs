using FluentValidation;
using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.Infrastructure.Validators.Messages
{
    public class DeleteMessageCommandValidator : AbstractValidator<DeleteMessageCommand>
    {
        public DeleteMessageCommandValidator()
        {
            RuleFor(x => x.MessageId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
        }
    }
}
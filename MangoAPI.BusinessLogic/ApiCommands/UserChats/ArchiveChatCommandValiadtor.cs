using FluentValidation;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandValidator : AbstractValidator<ArchiveChatCommand>
    {
        public ArchiveChatCommandValidator()
        {
            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("ArchiveChatCommand: Chat Id cannot be parsed.");

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("ArchiveChatCommand: User Id cannot be parsed.");
        }
    }
}

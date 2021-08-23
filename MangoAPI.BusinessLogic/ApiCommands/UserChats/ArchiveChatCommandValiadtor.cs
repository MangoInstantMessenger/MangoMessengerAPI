using FluentValidation;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandValiadtor : AbstractValidator<ArchiveChatCommand>
    {
        public ArchiveChatCommandValiadtor()
        {
            RuleFor(x => x.ChatId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("ArchiveChatCommand: Chat Id cannot be parsed.");

            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("ArchiveChatCommand: User Id cannot be parsed.");
        }
    }
}

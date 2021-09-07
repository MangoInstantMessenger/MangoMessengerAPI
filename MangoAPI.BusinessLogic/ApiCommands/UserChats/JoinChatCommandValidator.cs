using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class JoinChatCommandValidator : AbstractValidator<JoinChatCommand>
    {
        public JoinChatCommandValidator()
        {
            RuleFor(x => x.ChatId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("JoinChatCommand: Chat Id cannot be parsed.");

            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("JoinChatCommand: User Id cannot be parsed.");
        }
    }
}

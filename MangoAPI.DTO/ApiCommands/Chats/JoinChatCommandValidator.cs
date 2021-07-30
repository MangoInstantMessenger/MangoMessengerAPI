using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public class JoinChatCommandValidator : AbstractValidator<JoinChatCommand>
    {
        public JoinChatCommandValidator()
        {
            RuleFor(x => x.ChatId).NotNull().NotEmpty();
            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("JoinChatCommand: Chat Id cannot be parsed.");
            
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("JoinChatCommand: User Id cannot be parsed.");
        }
    }
}
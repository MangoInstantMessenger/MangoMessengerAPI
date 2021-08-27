using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class LeaveGroupCommandValidator : AbstractValidator<LeaveGroupCommand>
    {
        public LeaveGroupCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Leave group: User id can not be parsed");
            
            RuleFor(x => x.ChatId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Leave group: User id can not be parsed");
        }
    }
}
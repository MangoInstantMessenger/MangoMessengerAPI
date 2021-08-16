using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(x => x.GroupTitle)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.GroupType).IsInEnum();

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Create group: User Id cannot be parsed.");
        }
    }
}
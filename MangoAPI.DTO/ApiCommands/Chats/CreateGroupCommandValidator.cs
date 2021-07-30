using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(x => x.GroupTitle).NotNull().NotEmpty();
            RuleFor(x => x.GroupType).IsInEnum();
            
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Create group: User Id cannot be parsed.");
        }
    }
}
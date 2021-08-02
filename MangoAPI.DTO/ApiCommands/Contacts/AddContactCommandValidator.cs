using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Contacts
{
    public class AddContactCommandValidator : AbstractValidator<AddContactCommand>
    {
        public AddContactCommandValidator()
        {
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Create group: User Id cannot be parsed.");
        }
    }
}
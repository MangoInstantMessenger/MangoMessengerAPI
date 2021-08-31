using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class AddContactCommandValidator : AbstractValidator<AddContactCommand>
    {
        public AddContactCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Add Contact: User Id cannot be parsed.");

            RuleFor(x => x.ContactId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.ContactId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Add Contact: User Id cannot be parsed.");
        }
    }
}

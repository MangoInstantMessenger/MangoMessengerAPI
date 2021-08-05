using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Contacts
{
    public class AddContactCommandValidator : AbstractValidator<AddContactCommand>
    {
        public AddContactCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);
            
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Add Contact: User Id cannot be parsed.");
            
            RuleFor(x => x.ContactId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);
            
            RuleFor(x => x.ContactId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Add Contact: User Id cannot be parsed.");
        }
    }
}
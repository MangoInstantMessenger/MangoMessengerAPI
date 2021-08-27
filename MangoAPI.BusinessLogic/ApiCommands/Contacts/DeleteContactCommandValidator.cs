using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class DeleteContactCommandValidator : AbstractValidator<DeleteContactCommand>
    {
        public DeleteContactCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Delete Contact: User id can not be parsed");

            RuleFor(x => x.ContactId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Delete Contact: Contact id can not be parsed");
        }
    }
}
using FluentValidation;

namespace MangoAPI.Domain.Entities;

public class ContactEntityValidator : AbstractValidator<ContactEntity>
{
    public ContactEntityValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.ContactId).NotEmpty();
        RuleFor(x => x.CreatedAt).NotEmpty();
    }
}
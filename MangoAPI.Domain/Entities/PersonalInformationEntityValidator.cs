using FluentValidation;

namespace MangoAPI.Domain.Entities;

public class PersonalInformationEntityValidator : AbstractValidator<PersonalInformationEntity>
{
    public PersonalInformationEntityValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.CreatedAt).NotEmpty();
        RuleFor(x => x.Facebook).MaximumLength(50);
        RuleFor(x => x.Twitter).MaximumLength(50);
        RuleFor(x => x.Instagram).MaximumLength(50);
        RuleFor(x => x.LinkedIn).MaximumLength(50);
    }
}
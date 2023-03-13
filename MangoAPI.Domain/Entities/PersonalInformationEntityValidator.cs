using FluentValidation;

namespace MangoAPI.Domain.Entities;

public class PersonalInformationEntityValidator : AbstractValidator<PersonalInformationEntity>
{
    public PersonalInformationEntityValidator()
    {
    }
}
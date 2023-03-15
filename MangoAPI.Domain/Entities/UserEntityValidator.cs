using FluentValidation;

namespace MangoAPI.Domain.Entities;

public class UserEntityValidator : AbstractValidator<UserEntity>
{
    public UserEntityValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Username).NotEmpty().Length(5, 50);
        RuleFor(x => x.PasswordHash).NotEmpty();
        RuleFor(x => x.PasswordSalt).NotEmpty();
        RuleFor(x => x.ImageFileName).NotEmpty().MaximumLength(100);
        RuleFor(x => x.DisplayName).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Bio).MaximumLength(120);
        RuleFor(x => x.Website).MaximumLength(50);
        RuleFor(x => x.Address).MaximumLength(50);
    }
}
using FluentValidation;

namespace MangoAPI.Domain.Entities;

public class SessionEntityValidator : AbstractValidator<SessionEntity>
{
    public SessionEntityValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.CreatedAt).NotEmpty();
        RuleFor(x => x.ExpiresAt).NotEmpty();
    }
}
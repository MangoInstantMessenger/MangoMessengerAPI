using System;
using FluentValidation;
using MangoAPI.DTO.ApiQueries.Users;

namespace MangoAPI.Infrastructure.Validators.Users
{
    public class GetUserQueryValidator : AbstractValidator<GetUserQuery>
    {
        public GetUserQueryValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetUserQuery: User Id cannot be parsed.");
        }
    }
}
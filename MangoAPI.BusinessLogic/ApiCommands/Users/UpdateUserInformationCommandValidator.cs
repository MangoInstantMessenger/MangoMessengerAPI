namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System;
    using FluentValidation;

    public class UpdateUserInformationCommandValidator : AbstractValidator<UpdateUserInformationCommand>
    {
        public UpdateUserInformationCommandValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Update User Information: User Id cannot be parsed.");
        }
    }
}

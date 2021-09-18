using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChannelCommandValidator : AbstractValidator<CreateChannelCommand>
    {
        public CreateChannelCommandValidator()
        {
            RuleFor(x => x.ChannelTitle)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
                
            RuleFor(x => x.ChannelDescription)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.CommunityType).IsInEnum();
        }
    }
}

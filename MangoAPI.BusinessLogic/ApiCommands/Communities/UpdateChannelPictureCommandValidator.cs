using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChanelPictureCommandValidator : AbstractValidator<UpdateChanelPictureCommand>
    {
        private readonly List<string> _allowedExtensions = new()
        {
            "jpg", "JPG", "png", "PNG"
        };

        public UpdateChanelPictureCommandValidator()
        {
            RuleFor(x => x.ChatId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.NewGroupPicture).NotEmpty();
            RuleFor(x => x.NewGroupPicture.FileName).NotEmpty();

            RuleFor(x => x.NewGroupPicture.Length)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0)
                .LessThanOrEqualTo(2 * 1024 * 1024)
                .WithMessage("Image file should not exceed 2 MB.");

            RuleFor(x => x.NewGroupPicture.FileName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(HaveAllowedExtension)
                .WithMessage(
                    $"File extension is not allowed. Allowed extensions: {string.Join(", ", _allowedExtensions)}.")
                .Must(HaveValidName)
                .WithMessage("Invalid file name.")
                .Length(1, 20);
        }

        private static bool HaveValidName(string str)
        {
            var regex = new Regex(@"^[\w\-. ]+$");
            return regex.IsMatch(str);
        }

        private bool HaveAllowedExtension(string str)
        {
            var extension = str.Split('.').Last();
            return _allowedExtensions.Contains(extension);
        }
    }
}
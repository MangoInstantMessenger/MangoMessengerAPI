using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
    {
        private readonly List<string> _allowedExtensions = new()
        {
            "jpg", "JPG", "png", "PNG"
        };

        public UpdateProfilePictureCommandValidator()
        {
            RuleFor(x => x.PictureFile).NotEmpty();

            RuleFor(x => x.PictureFile.Length)
                .GreaterThan(0)
                .LessThanOrEqualTo(2 * 1024 * 1024)
                .WithMessage("Image file should not exceed 2 MB.");

            RuleFor(x => x.PictureFile.FileName)
                .NotEmpty()
                .Must(HaveAllowedExtension)
                .WithMessage(
                    $"File extension is not allowed. Allowed extensions: {string.Join(", ", _allowedExtensions)}.")
                .Must(HaveValidName)
                .WithMessage("Invalid file name.")
                .Length(1, 20);

            RuleFor(x => x.UserId).NotEmpty();
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
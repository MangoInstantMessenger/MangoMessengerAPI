using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public class UploadDocumentCommandValidator : AbstractValidator<UploadDocumentCommand>
    {
        private readonly List<string> _allowedExtensions = new()
        {
            "jpg", "JPG", "txt", "TXT", "pdf", "PDF", "gif", "GIF", "png", "PNG"
        };


        public UploadDocumentCommandValidator()
        {
            RuleFor(x => x.FormFile).NotEmpty();
            RuleFor(x => x.FormFile.Length)
                .GreaterThan(0)
                .LessThanOrEqualTo(5 * 1024 * 1024)
                .WithMessage("File size should not exceed 5 MB.");

            RuleFor(x => x.FormFile.FileName)
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
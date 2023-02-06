using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.Pipelines;

public class CommonFileValidator : AbstractValidator<IFormFile>
{
    private readonly List<string> allowedExtensions = new()
    {
        "jpg", "JPG", "txt", "TXT", "pdf", "PDF", "png", "PNG", "jpeg", "JPEG",
    };

    public CommonFileValidator()
    {
        RuleFor(x => x.Length)
            .Cascade(CascadeMode.Stop)
            .GreaterThan(0)
            .LessThanOrEqualTo(5 * 1024 * 1024)
            .WithMessage("File should not exceed 5 MB.");

        RuleFor(x => x.FileName)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Must(HaveAllowedExtension)
            .WithMessage(
                $"File extension is not allowed. Allowed extensions: {string.Join(", ", allowedExtensions)}.");
    }

    private bool HaveAllowedExtension(string str)
    {
        var extension = str.Split('.').Last();
        return allowedExtensions.Contains(extension);
    }
}

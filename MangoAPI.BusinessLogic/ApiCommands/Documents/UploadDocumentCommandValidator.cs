using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents;

public class UploadDocumentCommandValidator : AbstractValidator<UploadDocumentCommand>
{
    public UploadDocumentCommandValidator()
    {
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.ContentType).NotEmpty();

        _ = RuleFor(x => x.FormFile)
            .NotNull()
            .SetValidator(new CommonFileValidator());
    }
}

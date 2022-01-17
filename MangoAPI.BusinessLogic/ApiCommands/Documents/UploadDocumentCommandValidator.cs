using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents;

public class UploadDocumentCommandValidator : AbstractValidator<UploadDocumentCommand>
{
    public UploadDocumentCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
            
        RuleFor(x => x.FormFile)
            .NotNull()
            .SetValidator(new CommonFileValidator());
    }
}
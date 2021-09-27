using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public class UploadDocumentCommandValidator : AbstractValidator<UploadDocumentCommand>
    {
        public UploadDocumentCommandValidator()
        {
            RuleFor(x => x.FormFile).NotEmpty();
            RuleFor(x => x.FormFile.Length).LessThanOrEqualTo(5 * 1024 * 1024);
        }
    }
}
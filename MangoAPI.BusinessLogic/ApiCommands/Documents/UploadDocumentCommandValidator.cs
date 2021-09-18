using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public class UploadDocumentCommandValidator : AbstractValidator<UploadDocumentCommand>
    {
        public UploadDocumentCommandValidator()
        {
            RuleFor(x => x.FormFile).NotEmpty();
        }
    }
}
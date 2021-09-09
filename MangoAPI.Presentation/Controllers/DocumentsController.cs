using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    [Route("api/documents")]
    public class DocumentsController : ApiControllerBase, IDocumentsController
    {
        public DocumentsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> UploadDocumentAsync(IFormFile formFile,
            CancellationToken cancellationToken)
        {
            var command = new UploadDocumentCommand {FormFile = formFile};

            return await RequestAsync(command, cancellationToken);
        }
    }
}
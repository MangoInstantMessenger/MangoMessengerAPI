using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    [Route("api/documents")]
    public class DocumentsController : ApiControllerBase, IDocumentsController
    {
        public DocumentsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("fileName")]
        public async Task<IActionResult> UploadDocumentAsync(string fileName, CancellationToken cancellationToken)
        {
            var command = new UploadDocumentCommand {FileName = fileName};

            return await RequestAsync(command, cancellationToken);
        }
    }
}
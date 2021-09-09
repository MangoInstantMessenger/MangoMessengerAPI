using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for manipulations with documents.
    /// </summary>
    [ApiController]
    [Route("api/documents")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DocumentsController : ApiControllerBase, IDocumentsController
    {
        public DocumentsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Uploads document to the server. Requires role: User.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UploadDocumentAsync(IFormFile formFile,
            CancellationToken cancellationToken)
        {
            var command = new UploadDocumentCommand {FormFile = formFile};

            return await RequestAsync(command, cancellationToken);
        }
    }
}
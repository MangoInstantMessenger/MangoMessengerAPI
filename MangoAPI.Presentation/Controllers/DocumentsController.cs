using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

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
        public DocumentsController(IMediator mediator, IMapper mapper)
            : base(mediator, mapper)
        {
        }

        /// <summary>
        /// Uploads document to the server. Requires role: User.
        /// </summary>
        /// <param name="formFile">File to be uploaded.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        [HttpPost]
        [SwaggerOperation(Description = "Uploads document to the server. " +
                                        "Accepts formats: .jpg, .JPG, .txt, .TXT, .pdf, .PDF, .gif, .GIF. " +
                                        "Maximum file size: 10 MB. " +
                                        "Requires role: User.",
            Summary = "Uploads document to the server.")]
        [ProducesResponseType(typeof(UploadDocumentResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> UploadDocumentAsync(IFormFile formFile,
            CancellationToken cancellationToken)
        {
            var command = new UploadDocumentCommand { FormFile = formFile };

            return await RequestAsync(command, cancellationToken);
        }
    }
}
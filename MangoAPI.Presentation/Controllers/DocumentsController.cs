using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for manipulations with documents.
/// </summary>
[ApiController]
[Route("api/documents")]
[Authorize]
public class DocumentsController : ApiControllerBase, IDocumentsController
{
    public DocumentsController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext)
        : base(mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Uploads document to the server.
    /// </summary>
    /// <param name="formFile">File to be uploaded.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpPost]
    [SwaggerOperation(
        Description = "Uploads document to the server. " +
                      "Accepts formats: .jpg, .JPG, .txt, .TXT, .pdf, .PDF, " +
                      "Maximum file size: 5 MB. ",
        Summary = "Uploads document to the server.")]
    [ProducesResponseType(typeof(UploadDocumentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UploadDocumentAsync(
        IFormFile formFile,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new UploadDocumentCommand(
            FormFile: formFile,
            UserId: userId,
            ContentType: formFile.ContentType);

        return await RequestAsync(command, cancellationToken);
    }
}

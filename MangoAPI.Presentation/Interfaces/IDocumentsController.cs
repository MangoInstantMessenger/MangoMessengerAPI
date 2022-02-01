using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface IDocumentsController
{
    Task<IActionResult> UploadDocumentAsync(IFormFile formFile, CancellationToken cancellationToken);
}
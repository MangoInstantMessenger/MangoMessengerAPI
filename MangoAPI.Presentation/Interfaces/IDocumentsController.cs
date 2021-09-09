using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IDocumentsController
    {
        Task<IActionResult> UploadDocumentAsync(string fileName, CancellationToken cancellationToken);
    }
}
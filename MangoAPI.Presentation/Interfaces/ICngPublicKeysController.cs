using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface ICngPublicKeysController
{
    Task<IActionResult> GetPublicKeys(CancellationToken cancellationToken);
}
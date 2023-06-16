using MangoAPI.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Interfaces;

public interface IAiController
{
    Task<IActionResult> Send(string text, CancellationToken cancellationToken);
}
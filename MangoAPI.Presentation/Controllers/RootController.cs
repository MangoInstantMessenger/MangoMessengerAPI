using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

public class RootController : Controller
{
    /// <summary>
    /// Workaround for the redirect to angular UI. Return to it in future to fix better.
    /// </summary>
    [HttpGet]
    [Route("")]
    [SwaggerOperation(
        Description = "Workaround for the redirect to angular UI. Return to it in future to fix better.",
        Summary = "Workaround for the redirect to angular UI.")]
    public IActionResult RedirectToTheAngularSpa()
    {
        return Redirect(@"~/app");
    }
}

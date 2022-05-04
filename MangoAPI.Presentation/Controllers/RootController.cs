using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers;

public class RootController : Controller
{
    /// <summary>
    /// Workaround for the redirect to angular UI. Return to it in future to fix better.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("")]
    public IActionResult RedirectToTheAngularSpa()
    {
        return Redirect(@"~/app");
    }
}
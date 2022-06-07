using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for Public Key Entity
/// </summary>
[ApiController]
[Route("api/cng-public-keys")]
[Produces("application/json")]
[Authorize]
public class CngPublicKeysController : ApiControllerBase, ICngPublicKeysController
{
    public CngPublicKeysController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext) : base(
        mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Returns all user's Diffie-Hellman public keys.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [SwaggerOperation(
        Summary = "Returns all user's public keys.",
        Description = "Returns all user's Diffie-Hellman public keys.")]
    [ProducesResponseType(typeof(CngGetPublicKeysResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetPublicKeys(CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var query = new CngGetPublicKeysQuery { UserId = userId };

        return await RequestAsync(query, cancellationToken);
    }
}
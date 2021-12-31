using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.BusinessLogic.ApiQueries.PublicKeys;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for Public Key Entity
    /// </summary>
    [ApiController]
    [Route("api/public-keys")]
    [Produces("application/json")]
    [Authorize]
    public class PublicKeysController : ApiControllerBase, IPublicKeysController
    {
        public PublicKeysController(IMediator mediator, IMapper mapper)
            : base(mediator, mapper)
        {
        }

        /// <summary>
        /// Returns all user's Diffie-Hellman public keys. Required roles: User.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation(Summary = "Returns all user's public keys.",
            Description = "Returns all user's Diffie-Hellman public keys. Required roles: User.")]
        [ProducesResponseType(typeof(GetPublicKeysResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPublicKeys(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var query = new GetPublicKeysQuery { UserId = userId };

            return await RequestAsync(query, cancellationToken);
        }
    }
}
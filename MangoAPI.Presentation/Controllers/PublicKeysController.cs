using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Services;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/public-keys")]
    [Produces("application/json")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PublicKeysController : ApiControllerBase, IPublicKeysController
    {
        public PublicKeysController(IMediator mediator, IMapper mapper,
            RequestValidationService requestValidationService) 
            : base(mediator, mapper, requestValidationService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetPublicKeys(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
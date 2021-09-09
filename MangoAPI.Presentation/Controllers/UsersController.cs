using System;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for User Entity.
    /// </summary>
    [ApiController]
    [Route("api/users")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsersController : ApiControllerBase, IUsersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="mediator">Instance of mediator.</param>
        public UsersController(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Registers user in the system. There are two possibilities to verify account: Phone (1), Email (2).
        /// Does not require any authorization or users role.
        /// After registration user receives pair of access/refresh tokens.
        /// Access token claim role is Unverified.
        /// </summary>
        /// <param name="request">Request instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost]
        [AllowAnonymous]
        [SwaggerOperation(Summary =
            "Registers user in the system. There are two possibilities to verify account: Phone (1), Email (2). " +
            "Does not require any authorization or users role. " +
            "After registration user receives pair of access/refresh tokens. " +
            "Access token claim role is Unverified. ")]
        [ProducesResponseType(typeof(TokensResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Confirms user's email address. Adds a User role to the current user.
        /// This endpoint may be accessed by both roles: Unverified, User.
        /// On refresh session user receives new access token with updated roles.
        /// </summary>
        /// <param name="request">VerifyEmailRequest instance.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut("email-confirmation")]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Confirms user's email address. Adds a User role to the current user. " +
                                    "This endpoint may be accessed by both roles: Unverified, User. " +
                                    "On refresh session user receives new access token with updated roles. ")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> EmailConfirmationAsync([FromBody] VerifyEmailRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Confirms user's phone number. Adds a User role to the current user.
        /// This endpoint may be accessed by both roles: Unverified, User.
        /// On refresh session user receives new access token with updated roles.
        /// </summary>
        /// <param name="phoneCode">Code user enters in order to validate his phone number.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut("{phoneCode:int}")]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Confirms user's phone number. Adds a User role to the current user. " +
                                    "This endpoint may be accessed by both roles: Unverified, User. " +
                                    "On refresh session user receives new access token with updated roles. ")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> PhoneConfirmationAsync([FromRoute] int phoneCode,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            
            var command = new VerifyPhoneCommand
            {
                UserId = userId,
                ConfirmationCode = phoneCode,
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Changes password by current password. Required role: User.
        /// </summary>
        /// <param name="request">Request instance.</param>
        /// <param name="cancellationToken">Cancellation Token Instance.</param>
        /// <returns></returns>
        [HttpPut("password")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Changes password by current password. Required role: User")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            
            var command = request.ToCommand(userId);

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Gets user by ID. Requires role: User.
        /// </summary>
        /// <param name="userId">ID of the user to get, UUID.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("{userId}")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Gets user by ID. Requires role: User.")]
        [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUserById([FromRoute] Guid userId, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery
            {
                UserId = userId
            };
            
            return await RequestAsync(query, cancellationToken);
        }

        /// <summary>
        /// Gets info about current user himself.
        /// This endpoint may be accessed by both roles: Unverified, User.
        /// </summary>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Gets info about current user himself. " +
                                    "This endpoint may be accessed by both roles: Unverified, User.")]
        [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            
            var request = new GetUserQuery
            {
                UserId = userId
            };
            
            return await RequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// Updates user's social network user names. Requires role: User.
        /// </summary>
        /// <param name="request">UpdateUserSocialInformationRequest instance.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns></returns>
        [HttpPut("socials")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Updates user's social network user names. Requires role: User.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateUserSocialInformationAsync(
            [FromBody] UpdateUserSocialInformationRequest request,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();
            
            var command = request.ToCommand(currentUserId);

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Updates user's personal account information. Requires role: User.
        /// </summary>
        /// <param name="request">UpdateUserInformationRequest instance.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut("account")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Updates user's personal account information. Requires role: User.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateUserAccountInfoAsync([FromBody] UpdateUserAccountInfoRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            
            var command = request.ToCommand(userId);

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Updates user's public key. Requires role: User.
        /// </summary>
        /// <param name="publicKey">New public key.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut("public-key/{publicKey:int}")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Updates user's public key. Requires role: User.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdatePublicKeyAsync([FromRoute] int publicKey,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new UpdatePublicKeyCommand(userId, publicKey);

            return await RequestAsync(command, cancellationToken);
        }

        [HttpPut("picture/{image}")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Updates user's profile picture. Requires role: User.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateProfilePictureAsync([FromRoute] string image,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            
            var command = new UpdateProfilePictureCommand
            {
                UserId = userId, 
                Image = image
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for User Entity.
/// </summary>
[ApiController]
[Route("api/users")]
public class UsersController : ApiControllerBase, IUsersController
{
    public UsersController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext)
        : base(mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Registers user in the system. Then sends verification email.
    /// </summary>
    /// <param name="request">Request instance.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPost]
    [AllowAnonymous]
    [SwaggerOperation(
        Description = "Registers user in the system. Then sends verification email.",
        Summary = "Registers user in the system.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> RegisterAsync(
        [FromBody] RegisterRequest request,
        CancellationToken cancellationToken)
    {
        var command = Mapper.Map<RegisterCommand>(request);
        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Confirms user's email address.
    /// </summary>
    /// <param name="request">VerifyEmailRequest instance.</param>
    /// <param name="cancellationToken">CancellationToken instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPut("email-confirmation")]
    [AllowAnonymous]
    [SwaggerOperation(
        Description = "Confirms user's email address.",
        Summary = "Confirms user's email address.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> EmailConfirmationAsync(
        [FromBody] VerifyEmailRequest request,
        CancellationToken cancellationToken)
    {
        var command = Mapper.Map<VerifyEmailCommand>(request);
        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Changes password by current password.
    /// </summary>
    /// <param name="request">Request instance.</param>
    /// <param name="cancellationToken">Cancellation Token Instance.</param>
    [HttpPut("password")]
    [Authorize]
    [SwaggerOperation(
        Description = "Changes password by current password.",
        Summary = "Changes password by current password.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> ChangePassword(
        [FromBody] ChangePasswordRequest request,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new ChangePasswordCommand(
            UserId: userId,
            CurrentPassword: request.CurrentPassword,
            NewPassword: request.NewPassword,
            RepeatNewPassword: request.RepeatNewPassword);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Gets user by ID.
    /// </summary>
    /// <param name="userId">ID of the user to get, UUID.</param>
    /// <param name="cancellationToken">CancellationToken instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpGet("{userId:guid}")]
    [Authorize]
    [SwaggerOperation(
        Description = "Gets user by ID.",
        Summary = "Gets user by ID.")]
    [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> GetUserById([FromRoute] Guid userId, CancellationToken cancellationToken)
    {
        var query = new GetUserQuery(userId);

        return await RequestAsync(query, cancellationToken);
    }

    /// <summary>
    /// Updates user's social network user names.
    /// </summary>
    /// <param name="request">UpdateUserSocialInformationRequest instance.</param>
    /// <param name="cancellationToken">CancellationToken instance.</param>
    [HttpPut("socials")]
    [Authorize]
    [SwaggerOperation(
        Description = "Updates user's social network user names.",
        Summary = "Updates user's social network user names.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> UpdateUserSocialInformationAsync(
        [FromBody] UpdateUserSocialInformationRequest request,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new UpdateUserSocialInformationCommand(
            UserId: userId,
            Instagram: request.Instagram,
            LinkedIn: request.LinkedIn,
            Facebook: request.Facebook,
            Twitter: request.Twitter);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Updates user's personal account information.
    /// </summary>
    /// <param name="request">UpdateUserInformationRequest instance.</param>
    /// <param name="cancellationToken">CancellationToken instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPut("account")]
    [Authorize]
    [SwaggerOperation(
        Description = "Updates user's personal account information.",
        Summary = "Updates user's personal account information.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> UpdateUserAccountInfoAsync(
        [FromBody] UpdateUserAccountInfoRequest request,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new UpdateUserAccountInfoCommand(
            UserId: userId,
            Username: request.Username,
            DisplayName: request.DisplayName,
            Website: request.Website,
            Bio: request.Bio,
            Address: request.Address,
            BirthdayDate: request.BirthdayDate);

        return await RequestAsync(command, cancellationToken);
    }

    [HttpPost("picture")]
    [Authorize]
    [SwaggerOperation(
        Description = "Updates user's profile picture. Accepted formats .JPG, .PNG with size up to 2MB.",
        Summary = "Updates user's profile picture.")]
    [ProducesResponseType(typeof(UpdateProfilePictureResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> UpdateProfilePictureAsync(
        IFormFile pictureFile,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new UpdateProfilePictureCommand(
            UserId: userId,
            PictureFile: pictureFile,
            ContentType: pictureFile.ContentType);

        return await RequestAsync(command, cancellationToken);
    }
}

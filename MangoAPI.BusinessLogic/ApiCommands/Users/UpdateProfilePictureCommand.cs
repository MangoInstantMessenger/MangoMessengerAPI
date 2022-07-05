using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateProfilePictureCommand(
        Guid UserId,
        string ContentType,
        IFormFile PictureFile)
    : IRequest<Result<UpdateProfilePictureResponse>>;

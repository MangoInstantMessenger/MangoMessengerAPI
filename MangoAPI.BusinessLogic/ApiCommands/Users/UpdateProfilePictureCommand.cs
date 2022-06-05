using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateProfilePictureCommand : IRequest<Result<UpdateProfilePictureResponse>>
{
    public Guid UserId { get; init; }
    
    public IFormFile PictureFile { get; init; }

    public string ContentType { get; init; }
}
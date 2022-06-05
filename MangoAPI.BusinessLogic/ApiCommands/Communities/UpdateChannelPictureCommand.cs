using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record UpdateChanelPictureCommand : IRequest<Result<UpdateChannelPictureResponse>>
{
    public Guid UserId { get; init; }
    public Guid ChatId { get; init; }
    public IFormFile NewGroupPicture { get; init; }

    public string ContentType { get; init; }
}
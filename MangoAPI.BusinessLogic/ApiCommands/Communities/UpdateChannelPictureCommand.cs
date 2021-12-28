using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record UpdateChanelPictureCommand : IRequest<Result<UpdateChannelLogoResponse>>
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public IFormFile NewGroupPicture { get; set; }
    }
}
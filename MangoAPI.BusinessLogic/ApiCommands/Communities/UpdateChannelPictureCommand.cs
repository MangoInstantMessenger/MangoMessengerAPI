using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record UpdateChanelPictureCommand : IRequest<ResponseBase>
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public string Image { get; set; }
    }
}
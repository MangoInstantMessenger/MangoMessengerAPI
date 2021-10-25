using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record UpdateChanelPictureCommand : IRequest<Result<ResponseBase>>
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public string Image { get; set; }
    }
}
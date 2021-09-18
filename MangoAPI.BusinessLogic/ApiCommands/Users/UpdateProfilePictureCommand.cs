using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateProfilePictureCommand : IRequest<ResponseBase>
    {
        public Guid UserId { get; init; }
        public string Image { get; init; }
    }
}
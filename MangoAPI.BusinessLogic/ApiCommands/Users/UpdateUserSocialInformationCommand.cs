using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserSocialInformationCommand : IRequest<GenericResponse<ResponseBase>>
    {
        public Guid UserId { get; set; }
        public string Facebook { get; init; }
        public string Twitter { get; init; }
        public string Instagram { get; init; }
        public string LinkedIn { get; init; }
    }
}
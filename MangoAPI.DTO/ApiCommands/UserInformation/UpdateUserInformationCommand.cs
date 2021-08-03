using System;
using MangoAPI.DTO.Responses.UserInformation;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.UserInformation
{
    public class UpdateUserInformationCommand : IRequest<UpdateUserInformationResponse>
    {
        public string UserId { get; init; }
        
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public DateTime? BirthDay { get; init; }

        public string? Website { get; init; }
        public string? Address { get; init; }

        public string? Facebook { get; init; }
        public string? Twitter { get; init; }
        public string? Instagram { get; init; }
        public string? LinkedIn { get; init; }

        public string? ProfilePicture { get; init; }
    }
}
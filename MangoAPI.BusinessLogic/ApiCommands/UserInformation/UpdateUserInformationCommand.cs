﻿using System;
using MangoAPI.BusinessLogic.Responses.UserInformation;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserInformation
{
    public class UpdateUserInformationCommand : IRequest<UpdateUserInformationResponse>
    {
        public string UserId { get; init; } = null!;

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
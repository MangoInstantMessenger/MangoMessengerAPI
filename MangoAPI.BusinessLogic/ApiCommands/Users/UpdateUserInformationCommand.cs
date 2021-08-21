namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System;
    using MediatR;

    public class UpdateUserInformationCommand : IRequest<UpdateUserInformationResponse>
    {
        public string UserId { get; init; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string DisplayName { get; set; }

        public string MobileNumber { get; init; }

        public DateTime? BirthDay { get; init; }

        public string Email { get; init; }

        public string Website { get; init; }

        public string Username { get; init; }

        public string Bio { get; init; }

        public string Address { get; init; }

        public string Facebook { get; init; }

        public string Twitter { get; init; }

        public string Instagram { get; init; }

        public string LinkedIn { get; init; }
    }
}

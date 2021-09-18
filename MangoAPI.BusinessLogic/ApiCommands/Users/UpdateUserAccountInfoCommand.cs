using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserAccountInfoCommand : IRequest<ResponseBase>
    {
        public Guid UserId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string PhoneNumber { get; init; }
        public string BirthdayDate { get; init; }
        public string Email { get; init; }
        public string Website { get; init; }
        public string Username { get; init; }
        public string DisplayName { get; init; }
        public string Bio { get; init; }
        public string Address { get; init; }
    }
}
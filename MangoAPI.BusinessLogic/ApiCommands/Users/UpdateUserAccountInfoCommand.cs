using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateUserAccountInfoCommand(Guid UserId, string Username, string DisplayName, string Website, 
    string Bio, string Address, DateTime? BirthdayDate) : IRequest<Result<ResponseBase>>
{
    public Guid UserId { get; set; } = UserId;
}
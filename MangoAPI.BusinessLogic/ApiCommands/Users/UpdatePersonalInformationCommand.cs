using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdatePersonalInformationCommand(
        Guid UserId,
        string Instagram,
        string LinkedIn,
        string Facebook,
        string Twitter)
    : IRequest<Result<UpdatePersonalInformationResponse>>;
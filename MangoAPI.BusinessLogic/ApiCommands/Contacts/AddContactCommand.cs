using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts;

public record AddContactCommand(Guid UserId, Guid ContactId) : IRequest<Result<ResponseBase>>;
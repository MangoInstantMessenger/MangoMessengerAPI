using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateChatCommand(Guid UserId, Guid PartnerId) : IRequest<Result<CreateCommunityResponse>>;
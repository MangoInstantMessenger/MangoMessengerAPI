using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public record GetMessagesQuery(Guid UserId, Guid ChatId)
    : IRequest<Result<GetMessagesResponse>>;

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public record SearchChatMessagesQuery(Guid UserId, Guid ChatId, string MessageText) 
    : IRequest<Result<SearchChatMessagesResponse>>;
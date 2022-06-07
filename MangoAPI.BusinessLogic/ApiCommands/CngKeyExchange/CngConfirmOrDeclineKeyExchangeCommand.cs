using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngConfirmOrDeclineKeyExchangeCommand : IRequest<Result<ResponseBase>>
{
    public CngConfirmOrDeclineKeyExchangeCommand()
    {
        
    }

    public CngConfirmOrDeclineKeyExchangeCommand(Guid userId, Guid requestId, bool confirmed, string publicKey)
    {
        UserId = userId;
        RequestId = requestId;
        Confirmed = confirmed;
        PublicKey = publicKey;
    }
    
    public Guid UserId { get; init; }
    public Guid RequestId { get; init; }
    public bool Confirmed { get; init; }
    public string PublicKey { get; init; }
}
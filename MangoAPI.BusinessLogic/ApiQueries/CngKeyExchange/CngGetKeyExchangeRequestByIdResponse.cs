using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public record CngGetKeyExchangeRequestByIdResponse : ResponseBase
{
    public KeyExchangeRequest KeyExchangeRequest { get; init; }
    
    public static CngGetKeyExchangeRequestByIdResponse FromSuccess(KeyExchangeRequest request) 
        => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            KeyExchangeRequest = request
        };
}
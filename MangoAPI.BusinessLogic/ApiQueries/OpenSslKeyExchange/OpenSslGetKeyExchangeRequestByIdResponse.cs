using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetKeyExchangeRequestByIdResponse : ResponseBase
{
    public OpenSslKeyExchangeRequest KeyExchangeRequest { get; init; }

    public static OpenSslGetKeyExchangeRequestByIdResponse FromSuccess(OpenSslKeyExchangeRequest keyExchangeRequest)
    {
        var result = new OpenSslGetKeyExchangeRequestByIdResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            KeyExchangeRequest = keyExchangeRequest
        };

        return result;
    }
}
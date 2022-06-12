using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record GetKeyExchangeRequestByIdResponse : ResponseBase
{
    public OpenSslKeyExchangeRequest KeyExchangeRequest { get; init; }

    public static GetKeyExchangeRequestByIdResponse FromSuccess(OpenSslKeyExchangeRequest keyExchangeRequest)
    {
        var result = new GetKeyExchangeRequestByIdResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            KeyExchangeRequest = keyExchangeRequest
        };

        return result;
    }
}
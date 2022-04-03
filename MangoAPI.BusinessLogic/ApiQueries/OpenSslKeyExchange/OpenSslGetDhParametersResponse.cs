using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetDhParametersResponse : ResponseBase
{
    public byte[] FileContent { get; init; }
}
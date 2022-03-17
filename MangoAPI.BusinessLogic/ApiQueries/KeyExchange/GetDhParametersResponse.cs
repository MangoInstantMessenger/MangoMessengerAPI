using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record GetDhParametersResponse : ResponseBase
{
    public byte[] FileContent { get; init; }
}
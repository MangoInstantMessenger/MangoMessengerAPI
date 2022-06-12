using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record GetDhParametersResponse : ResponseBase
{
    public byte[] FileContent { get; init; }
}
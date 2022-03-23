using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys;

public record CngGetPublicKeysResponse : ResponseBase
{
    public List<CngPublicKey> PublicKeys { get; init; }
}
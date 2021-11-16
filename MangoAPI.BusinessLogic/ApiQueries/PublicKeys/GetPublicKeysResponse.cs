using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys
{
    public record GetPublicKeysResponse : ResponseBase
    {
        public List<PublicKey> PublicKeys { get; init; }
    }
}
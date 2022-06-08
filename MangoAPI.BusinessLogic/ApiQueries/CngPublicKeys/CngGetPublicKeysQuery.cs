using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;

public record CngGetPublicKeysQuery(Guid UserId) : IRequest<Result<CngGetPublicKeysResponse>>;
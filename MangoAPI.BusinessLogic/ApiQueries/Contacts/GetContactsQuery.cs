using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public record GetContactsQuery(Guid UserId)
    : IRequest<Result<GetContactsResponse>>;
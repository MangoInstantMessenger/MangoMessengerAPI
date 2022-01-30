using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public record GetContactsQuery : IRequest<Result<GetContactsResponse>>
{
    public Guid UserId { get; init; }
}
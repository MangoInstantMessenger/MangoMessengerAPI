using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public record SearchContactQuery(string SearchQuery, Guid UserId) : IRequest<Result<SearchContactResponse>>;
using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record SearchContactQuery : IRequest<SearchContactResponse>
    {
        public Guid UserId { get; init; }
        public string SearchQuery { get; init; }
    }
}
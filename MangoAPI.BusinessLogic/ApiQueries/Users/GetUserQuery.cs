namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using MediatR;

    public record GetUserQuery : IRequest<GetUserResponse>
    {
        public string UserId { get; init; }
    }
}

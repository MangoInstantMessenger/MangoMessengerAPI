using MediatR;

namespace MangoAPI.DTO.Commands
{
    public class AuthorizedCommand<TResponse> : IRequest<TResponse>
    {
        public string UserId { get; set; }
    }
}
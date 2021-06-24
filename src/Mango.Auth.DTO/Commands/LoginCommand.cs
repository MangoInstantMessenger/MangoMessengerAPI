using Mango.Auth.DTO.Models;
using MediatR;

namespace Mango.Auth.DTO.Commands
{
    public class LoginCommand : IRequest<User>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Mango.Auth.Domain;
using MangoAPI.WebApp.Exceptions;
using MangoAPI.WebApp.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.User.Login
{
    public class LoginHandler : IRequestHandler<LoginQuery, User>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;

        public LoginHandler(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, 
            IJwtGenerator jwtGenerator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<User> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                throw new RestException(HttpStatusCode.Unauthorized);
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                return new User
                {
                    DisplayName = user.DisplayName,
                    Token = _jwtGenerator.CreateToken(user),
                    UserName = user.UserName,
                    Image = null
                };
            }

            throw new RestException(HttpStatusCode.Unauthorized);
        }
    }
}
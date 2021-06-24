using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Data.Context;
using MangoAPI.Data.Entities;
using MangoAPI.Exceptions;
using MangoAPI.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.User.Registration
{
    public class RegistrationHandler : IRequestHandler<RegistrationCommand, User>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly DataContext _context;

        public RegistrationHandler(UserManager<AppUser> userManager, IJwtGenerator jwtGenerator, DataContext context)
        {
            _userManager = userManager;
            _jwtGenerator = jwtGenerator;
            _context = context;
        }


        public async Task<User> Handle(RegistrationCommand request, CancellationToken cancellationToken)
        {
            if (await _context.Users.Where(x => x.Email == request.Email).AnyAsync(cancellationToken))
            {
                throw new RestException(HttpStatusCode.BadRequest, new {Email = "Email already exist"});
            }

            if (await _context.Users.Where(x => x.UserName == request.UserName).AnyAsync(cancellationToken))
            {
                throw new RestException(HttpStatusCode.BadRequest, new {UserName = "UserName already exist"});
            }

            var user = new AppUser
            {
                DisplayName = request.DisplayName,
                Email = request.Email,
                UserName = request.UserName
            };

            var result = await _userManager.CreateAsync(user, request.Password);

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

            throw new Exception("Client creation failed");
        }
    }
}
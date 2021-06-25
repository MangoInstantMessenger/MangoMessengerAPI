using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Exceptions;
using MangoAPI.Domain;
using MangoAPI.DTO.Commands;
using MangoAPI.DTO.Models;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Application.CommandHandlers
{
    public class RegistrationCommandHandler : IRequestHandler<RegistrationCommand, User>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly UserDbContext _dbContext;

        public RegistrationCommandHandler(UserManager<UserEntity> userManager, IJwtGenerator jwtGenerator,
            UserDbContext dbContext)
        {
            _userManager = userManager;
            _jwtGenerator = jwtGenerator;
            _dbContext = dbContext;
        }


        public async Task<User> Handle(RegistrationCommand request, CancellationToken cancellationToken)
        {
            if (await _dbContext.Users.Where(x => x.Email == request.Email).AnyAsync(cancellationToken))
            {
                throw new RestException(HttpStatusCode.BadRequest, new {Email = "Email already exist"});
            }

            if (await _dbContext.Users.Where(x => x.UserName == request.UserName).AnyAsync(cancellationToken))
            {
                throw new RestException(HttpStatusCode.BadRequest, new {UserName = "UserName already exist"});
            }

            var user = new UserEntity
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
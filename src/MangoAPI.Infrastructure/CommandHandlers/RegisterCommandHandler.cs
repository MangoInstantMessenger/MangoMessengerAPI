using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Exceptions;
using MangoAPI.Domain.Auth;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
    {
        private readonly UserDbContext _dbContext;

        public RegisterCommandHandler(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var userExists = await _dbContext.RegisterRequests
                .Where(x => x.Email == request.Email).AnyAsync(cancellationToken);
            
            if (userExists)
            {
                throw new RestException(HttpStatusCode.BadRequest, 
                    new {Email = "Email already exist. Forgot password?"});
            }

            if (!request.TermsAccepted)
            {
                throw new RestException(HttpStatusCode.BadRequest,
                    new {TermsAccepted = "In order to register you must accept the terms of service."});
            }

            var registerRequest = new RegisterRequestEntity
            {
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.Now
            };

            await _dbContext.RegisterRequests.AddAsync(registerRequest, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            // send verification email here

            return await Task.FromResult(new RegisterResponse
            {
                Message = "Registration was successful. Confirm your email."
            });
        }
    }
}
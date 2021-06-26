using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResponse>
    {
        private readonly MangoPostgresDbContext _dbContext;

        public RegisterCommandHandler(MangoPostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var exists = await _dbContext.RegisterRequests
                .AnyAsync(x => x.Email == request.Email, cancellationToken);

            if (exists)
            {
                return await Task.FromResult(new RegisterResponse
                {
                    Message = "Email already registered. Forgot password? Restore your password.",
                    AlreadyRegistered = true,
                    TermsAccepted = request.TermsAccepted
                });
            }

            if (!request.TermsAccepted)
            {
                return await Task.FromResult(new RegisterResponse
                {
                    Message = "In order to register accept terms of service.",
                    AlreadyRegistered = false,
                    TermsAccepted = false
                });
            }

            var registerRequest = new RegisterRequestEntity
            {
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.Now,
                ConfirmLinkCode = new Random().Next(100000, 999999)
            };

            await _dbContext.RegisterRequests.AddAsync(registerRequest, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return await Task.FromResult(new RegisterResponse
            {
                Message = "Registration was successful. Confirm your email.",
                AlreadyRegistered = false,
                TermsAccepted = true
            });
        }
    }
}
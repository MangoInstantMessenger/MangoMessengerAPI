using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, VerifyEmailResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<VerifyEmailResponse> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var guidParsed = Guid.TryParse(request.UserId, out _);

            if (!guidParsed)
            {
                return VerifyEmailResponse.InvalidUserId;
            }

            var user = await _userManager.FindByIdAsync(request.UserId);

            if (user is null)
            {
                return VerifyEmailResponse.UserNotFound;
            }

            if (user.Email != request.Email)
            {
                return VerifyEmailResponse.InvalidEmail;
            }

            if (user.EmailConfirmed)
            {
                return VerifyEmailResponse.EmailAlreadyVerified;
            }

            user.EmailConfirmed = true;

            _postgresDbContext.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return VerifyEmailResponse.SuccessResponse;
        }
    }
}
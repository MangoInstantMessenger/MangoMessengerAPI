using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, VerifyEmailResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public VerifyEmailCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<VerifyEmailResponse> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var guidParsed = Guid.TryParse(request.UserId, out var parsedGuid);

            if (!guidParsed)
            {
                return VerifyEmailResponse.InvalidUserId;
            }

            var user = await _postgresDbContext
                .Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId && x.Email == request.Email, cancellationToken);

            if (user == null)
            {
                return VerifyEmailResponse.UserNotFound;
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
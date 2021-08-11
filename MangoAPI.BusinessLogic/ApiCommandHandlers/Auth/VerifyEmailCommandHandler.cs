using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.BusinessExceptions;
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
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var user = await _userManager.FindByIdAsync(request.UserId);

                if (user is null)
                {
                    throw new BusinessException(ResponseMessageCodes.UserNotFound);
                }

                if (user.Email != request.Email)
                {
                    throw new BusinessException(ResponseMessageCodes.InvalidEmail);
                }

                if (user.EmailConfirmed)
                {
                    throw new BusinessException(ResponseMessageCodes.EmailAlreadyVerified);
                }

                user.EmailConfirmed = true;

                _postgresDbContext.Update(user);

                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return VerifyEmailResponse.SuccessResponse;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
        }
    }
}
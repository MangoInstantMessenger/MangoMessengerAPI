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
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public LogoutCommandHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<LogoutResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var token = await _postgresDbContext.RefreshTokens
                    .FirstOrDefaultAsync(x => x.Id == request.RefreshTokenId, cancellationToken);

                if (token is null)
                {
                    throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
                }

                var user = await _userManager.FindByIdAsync(token.UserId);

                if (user is null || token.UserId != user.Id)
                {
                    throw new BusinessException(ResponseMessageCodes.UserNotFound);
                }

                _postgresDbContext.RefreshTokens.Remove(token);
                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return LogoutResponse.SuccessResponse;
            }
            catch (Exception e)
            {
                transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
           
        }
    }
}
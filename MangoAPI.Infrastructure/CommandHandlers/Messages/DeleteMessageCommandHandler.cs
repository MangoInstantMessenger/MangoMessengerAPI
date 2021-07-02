using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public DeleteMessageCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }


        public async Task<DeleteMessageResponse> Handle(DeleteMessageCommand request,
            CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return DeleteMessageResponse.Suspicious;
            }

            if (!validationResult.Success)
            {
                return DeleteMessageResponse.RefreshTokenNotValidated;
            }

            var currentUser = await _postgresDbContext
                .Users
                .Include(x => x.Messages)
                .FirstAsync(x => x.Id == validationResult.RefreshToken.UserId, cancellationToken);

            if (currentUser == null)
            {
                return DeleteMessageResponse.UserNotFound;
            }

            var message = currentUser.Messages
                .FirstOrDefault(x => x.Id == request.MessageId);

            if (message == null)
            {
                return DeleteMessageResponse.MessageNotFound;
            }

            _postgresDbContext.Messages.Remove(message);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return DeleteMessageResponse.FromSuccess;
        }
    }
}
using System;
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
    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public EditMessageCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return EditMessageResponse.Suspicious;
            }

            if (!validationResult.Success)
            {
                return EditMessageResponse.RefreshTokenNotValidated;
            }

            var currentUser = await _postgresDbContext
                .Users
                .Include(x => x.Messages)
                .FirstAsync(x => x.Id == validationResult.RefreshToken.UserId, cancellationToken);

            if (currentUser == null)
            {
                return EditMessageResponse.UserNotFound;
            }

            var message = currentUser.Messages
                .FirstOrDefault(x => x.Id == request.MessageId);

            if (message == null)
            {
                return EditMessageResponse.MessageNotFound;
            }

            message.Content = request.ModifiedText;
            message.Updated = DateTime.Now;

            _postgresDbContext.Update(message);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return EditMessageResponse.FromSuccess;
        }
    }
}
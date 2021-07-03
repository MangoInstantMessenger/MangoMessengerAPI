using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IUserService _userService;

        public DeleteMessageCommandHandler(ICookieService cookieService, MangoPostgresDbContext postgresDbContext,
            IUserService userService)
        {
            _cookieService = cookieService;
            _postgresDbContext = postgresDbContext;
            _userService = userService;
        }
        
        public async Task<DeleteMessageResponse> Handle(DeleteMessageCommand request,
            CancellationToken cancellationToken)
        {
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var currentUser = await _userService.GetUserByTokenIdAsync(refreshTokenId);

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

            return DeleteMessageResponse.SuccessResponse;
        }
    }
}
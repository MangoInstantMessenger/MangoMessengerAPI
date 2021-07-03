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

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand, EditMessageResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IUserService _userService;

        public EditMessageCommandHandler(ICookieService cookieService, MangoPostgresDbContext postgresDbContext,
            IUserService userService)
        {
            _cookieService = cookieService;
            _postgresDbContext = postgresDbContext;
            _userService = userService;
        }

        public async Task<EditMessageResponse> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var currentUser = await _userService.GetUserByTokenIdAsync(refreshTokenId);

            if (currentUser == null)
            {
                return EditMessageResponse.UserNotFound;
            }

            var message = currentUser.Messages.FirstOrDefault(x => x.Id == request.MessageId);

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
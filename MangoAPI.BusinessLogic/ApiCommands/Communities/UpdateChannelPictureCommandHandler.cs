using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChannelPictureCommandHandler 
        : IRequestHandler<UpdateChanelPictureCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public UpdateChannelPictureCommandHandler(MangoPostgresDbContext postgresDbContext, 
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(UpdateChanelPictureCommand request, 
            CancellationToken cancellationToken)
        {
            var userChat = await _postgresDbContext.UserChats.AsNoTracking()
                .Include(x => x.Chat)
                .FirstOrDefaultAsync(x => x.ChatId == request.ChatId &&
                                          x.UserId == request.UserId &&
                                          x.RoleId == (int)UserRole.Owner &&
                                          x.Chat.CommunityType != (int)CommunityType.DirectChat,
                    cancellationToken);

            if (userChat is null)
            {
                const string errorMessage = ResponseMessageCodes.ChatNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            userChat.Chat.Image = request.Image;

            _postgresDbContext.Update(userChat.Chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
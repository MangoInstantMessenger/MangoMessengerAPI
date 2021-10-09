using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChannelPictureCommandHandler : IRequestHandler<UpdateChanelPictureCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateChannelPictureCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<ResponseBase> Handle(UpdateChanelPictureCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);
            
            if (user is null)
            {
               throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chat = await _postgresDbContext.Chats.FindChatByIdAsync(request.ChatId, cancellationToken);

            if (chat is null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            if (chat.CommunityType == (int) CommunityType.DirectChat)
            {
                throw new BusinessException(ResponseMessageCodes.PermissionDenied);
            }

            chat.Image = request.Image;

            _postgresDbContext.Chats.Update(chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return ResponseBase.SuccessResponse;
        }
    }
}
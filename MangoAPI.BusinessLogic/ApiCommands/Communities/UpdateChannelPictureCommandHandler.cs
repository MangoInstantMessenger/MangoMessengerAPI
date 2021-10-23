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
        : IRequestHandler<UpdateChanelPictureCommand, GenericResponse<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateChannelPictureCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase>> Handle(UpdateChanelPictureCommand request, 
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
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.ChatNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ChatNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            userChat.Chat.Image = request.Image;

            _postgresDbContext.Update(userChat.Chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
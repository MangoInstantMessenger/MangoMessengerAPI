using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class GetCommunityByIdQueryHandler : IRequestHandler<GetCommunityByIdQuery, 
        GenericResponse<GetCommunityByIdResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetCommunityByIdQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<GetCommunityByIdResponse>> Handle(GetCommunityByIdQuery request, CancellationToken cancellationToken)
        {
            var chatEntity =
                await _postgresDbContext.Chats.FindChatByIdIncludeMessagesAsync(request.ChatId,
                    cancellationToken);

            if (chatEntity is null)
            {
                return new GenericResponse<GetCommunityByIdResponse>
                {
                    Error = new ErrorResponse()
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

            var userChat =
                await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId,
                    cancellationToken);

            switch (userChat)
            {
                case null when chatEntity.CommunityType == (int) CommunityType.DirectChat:
                    return new GenericResponse<GetCommunityByIdResponse>
                    {
                        Error = new ErrorResponse()
                        {
                            ErrorMessage = ResponseMessageCodes.ChatNotFound,
                            ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ChatNotFound],
                            Success = false,
                            StatusCode = 409
                        },
                        Response = null,
                        StatusCode = 409
                    };

                case null when chatEntity.CommunityType == (int) CommunityType.PrivateChannel:
                    return new GenericResponse<GetCommunityByIdResponse>
                    {
                        Error = new ErrorResponse()
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

            if (chatEntity.CommunityType == (int) CommunityType.DirectChat)
            {
                var colleague = (await _postgresDbContext
                        .UserChats
                        .AsNoTracking()
                        .Include(x => x.User)
                        .FirstOrDefaultAsync(x => x.ChatId == chatEntity.Id && x.UserId != request.UserId,
                        cancellationToken)).User;

                chatEntity.Title = colleague.DisplayName;
                chatEntity.Image = colleague.Image;
            }

            var chat = new Chat
            {
                ChatId = chatEntity.Id,
                Title = chatEntity.Title,
                CommunityType = (CommunityType) chatEntity.CommunityType,
                ChatLogoImageUrl = StringService.GetDocumentUrl(chatEntity.Image),
                Description = chatEntity.Description,
                MembersCount = chatEntity.MembersCount,
                IsMember = userChat != null,
                IsArchived = userChat is { IsArchived: true },
                LastMessage = chatEntity.Messages.Any()
                    ? chatEntity.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Select(x => new Message
                    {
                        MessageId = x.Id,
                        UserDisplayName = x.User.DisplayName,
                        MessageText = x.Content,
                        CreatedAt = x.CreatedAt.ToShortTimeString(),
                        UpdatedAt = x.UpdatedAt?.ToShortTimeString(),
                        IsEncrypted = x.IsEncrypted,
                        AuthorPublicKey = x.AuthorPublicKey,
                        MessageAuthorPictureUrl = StringService.GetDocumentUrl(x.User.Image),
                    }).Last()
                    : null,
            };

            return new GenericResponse<GetCommunityByIdResponse>
            {
                Error = null,
                Response = GetCommunityByIdResponse.FromSuccess(chat),
                StatusCode = 200
            };
        }
    }
}
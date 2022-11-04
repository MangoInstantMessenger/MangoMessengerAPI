using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public class SearchCommunityQueryHandler
    : IRequestHandler<SearchCommunityQuery, Result<SearchCommunityResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<SearchCommunityResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public SearchCommunityQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<SearchCommunityResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SearchCommunityResponse>> Handle(
        SearchCommunityQuery request,
        CancellationToken cancellationToken)
    {
        var query = dbContext.Chats
            .AsNoTracking()
            .Where(x => x.CommunityType == CommunityType.PublicChannel)
            .Where(x => EF.Functions.Like(x.Title, $"%{request.DisplayName}%"))
            .Select(x => new Chat
            {
                ChatId = x.Id,
                Title = x.Title,
                CommunityType = x.CommunityType,
                ChatLogoImageUrl = x.Image != null
                    ? $"{blobServiceSettings.MangoBlobAccess}/{x.Image}"
                    : null,
                Description = x.Description,
                MembersCount = x.MembersCount,
                IsArchived = false,
                IsMember = false,
                UpdatedAt = x.UpdatedAt,
                LastMessageAuthor = x.LastMessageAuthor,
                LastMessageText = x.LastMessageText,
                LastMessageTime = x.LastMessageTime,
                LastMessageId = x.LastMessageId,
            }).Distinct();

        var userChats = await dbContext.UserChats
            .AsNoTracking()
            .Where(x => x.UserId == request.UserId)
            .Select(x => x.ChatId)
            .ToListAsync(cancellationToken);

        var set = userChats.ToHashSet();

        var chats = await query.Take(200).ToListAsync(cancellationToken);

        foreach (var c in chats)
        {
            if (set.Contains(c.ChatId))
            {
                c.IsMember = true;
            }
        }

        return responseFactory.SuccessResponse(SearchCommunityResponse.FromSuccess(chats));
    }
}

using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Enums;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public class SearchCommunityQueryHandler
    : IRequestHandler<SearchCommunityQuery, Result<SearchCommunityResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<SearchCommunityResponse> _responseFactory;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public SearchCommunityQueryHandler(MangoDbContext dbContext,
        ResponseFactory<SearchCommunityResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SearchCommunityResponse>> Handle(SearchCommunityQuery request,
        CancellationToken cancellationToken)
    {
        IQueryable<Chat> query;

        var isRelational = _dbContext.Database.IsRelational();

        // TODO: Fix this IF-ELSE is workaround in order to complete test with in-memory database
        if (isRelational)
        {
            query = _dbContext.Chats
                .AsNoTracking()
                .Where(x => x.CommunityType == (int) CommunityType.PublicChannel)
                .Where(x => EF.Functions.Like(x.Title, $"%{request.DisplayName}%"))
                .Select(x => new Chat
                {
                    ChatId = x.Id,
                    Title = x.Title,
                    CommunityType = (CommunityType) x.CommunityType,
                    ChatLogoImageUrl = x.Image != null
                        ? $"{_blobServiceSettings.MangoBlobAccess}/{x.Image}"
                        : null,
                    Description = x.Description,
                    MembersCount = x.MembersCount,
                    IsArchived = false,
                    IsMember = false,
                    UpdatedAt = x.UpdatedAt,
                    LastMessageAuthor = x.LastMessageAuthor,
                    LastMessageText = x.LastMessageText,
                    LastMessageTime = x.LastMessageTime,
                    LastMessageId = x.LastMessageId
                }).Distinct();
        }
        else
        {
            query = _dbContext.Chats
                .AsNoTracking()
                .Where(x => x.CommunityType == (int) CommunityType.PublicChannel)
                .Where(x => x.Title.Contains(request.DisplayName))
                .Select(x => new Chat
                {
                    ChatId = x.Id,
                    Title = x.Title,
                    CommunityType = (CommunityType) x.CommunityType,
                    ChatLogoImageUrl = x.Image != null
                        ? $"{_blobServiceSettings.MangoBlobAccess}/{x.Image}"
                        : null,
                    Description = x.Description,
                    MembersCount = x.MembersCount,
                    IsArchived = false,
                    IsMember = false,
                    UpdatedAt = x.UpdatedAt,
                    LastMessageAuthor = x.LastMessageAuthor,
                    LastMessageText = x.LastMessageText,
                    LastMessageTime = x.LastMessageTime,
                    LastMessageId = x.LastMessageId
                }).Distinct();
        }

        var chats = await query.Take(200).ToListAsync(cancellationToken);

        return _responseFactory.SuccessResponse(SearchCommunityResponse.FromSuccess(chats));
    }
}
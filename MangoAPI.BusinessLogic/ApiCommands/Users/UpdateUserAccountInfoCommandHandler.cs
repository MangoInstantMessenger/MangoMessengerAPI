using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class
    UpdateUserAccountInfoCommandHandler : IRequestHandler<UpdateUserAccountInfoCommand,
        Result<UpdateUserAccountInfoResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<UpdateUserAccountInfoResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public UpdateUserAccountInfoCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UpdateUserAccountInfoResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<UpdateUserAccountInfoResponse>> Handle(
        UpdateUserAccountInfoCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .Include(x => x.PersonalInformation)
            .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        if (user.DisplayName != request.DisplayName)
        {
            var userChats = await dbContext.UserChats
                .Include(x => x.Chat)
                .Where(x =>
                    x.UserId == user.Id &&
                    x.Chat.CommunityType == CommunityType.DirectChat)
                .Select(x => x.Chat)
                .ToListAsync(cancellationToken);

            foreach (var chatEntity in userChats)
            {
                var newTitle = chatEntity.Title.Replace(user.DisplayName, request.DisplayName);
                var newDescription = chatEntity.Description.Replace(user.DisplayName, request.DisplayName);
                chatEntity.UpdateTitle(newTitle);
                chatEntity.UpdateDescription(newDescription);
            }

            user.SetDisplayName(request.DisplayName);

            dbContext.Chats.UpdateRange(userChats);
        }

        user.UpdateUserData(
            request.Bio,
            request.Website,
            request.Birthday,
            request.Address,
            request.Username);

        await dbContext.SaveChangesAsync(cancellationToken);

        var userDto = new User
        {
            UserId = user.Id,
            DisplayName = user.DisplayName,
            DisplayNameColour = user.DisplayNameColour,
            Address = user.Address,
            Birthday = user.Birthday?.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture),
            Website = user.Website,
            Facebook = user.PersonalInformation?.Facebook,
            Twitter = user.PersonalInformation?.Twitter,
            Instagram = user.PersonalInformation?.Instagram,
            LinkedIn = user.PersonalInformation?.LinkedIn,
            Username = user.Username,
            Bio = user.Bio,
            PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{user.ImageFileName}",
        };

        var response = UpdateUserAccountInfoResponse.FromSuccess(userDto);
        var result = responseFactory.SuccessResponse(response);

        return result;
    }
}
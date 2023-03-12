using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<TokensResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly IUserManagerService userManager;
    private readonly ResponseFactory<TokensResponse> responseFactory;
    private readonly IJwtGenerator jwtGenerator;
    private readonly IJwtGeneratorSettings jwtGeneratorSettings;
    private readonly IBlobServiceSettings blobServiceSettings;
    // private readonly PasswordHashService passwordHashService;
    private readonly IMangoUserSettings mangoUserSettings;
    private readonly IAvatarService avatarService;

    private readonly UserEntity mangoUser = new()
    {
        PhoneNumber = "56272381753",
        DisplayName = "Mango Messenger",
        DisplayNameColour = DisplayNameColour.Violet,
        Bio = "Service notifications",
        Id = SeedDataConstants.MangoId,
        UserName = "MangoMessenger",
        Email = "mango.messenger@wp.pl",
        NormalizedEmail = "MANGO.MESSENGER@WP.PL",
        EmailConfirmed = true,
        PhoneNumberConfirmed = true,
        Image = "mango_logo.png",
    };

    public RegisterCommandHandler(
        IUserManagerService userManager,
        MangoDbContext dbContext,
        IJwtGenerator jwtGenerator,
        IJwtGeneratorSettings jwtGeneratorSettings,
        ResponseFactory<TokensResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings,
        // PasswordHashService passwordHashService,
        IMangoUserSettings mangoUserSettings,
        IAvatarService avatarService)
    {
        this.userManager = userManager;
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.jwtGenerator = jwtGenerator;
        this.jwtGeneratorSettings = jwtGeneratorSettings;
        this.blobServiceSettings = blobServiceSettings;
        // this.passwordHashService = passwordHashService;
        this.mangoUserSettings = mangoUserSettings;
        this.avatarService = avatarService;
    }

    public async Task<Result<TokensResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var userExists = await dbContext.Users
            .AnyAsync(entity => entity.Email == request.Email, cancellationToken);

        if (userExists)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var color = new Random().Next(11);

        var defaultAvatar = avatarService.GetRandomAvatar();

        var newUser = new UserEntity
        {
            DisplayName = request.DisplayName,
            UserName = Guid.NewGuid().ToString(),
            Email = request.Email,
            Image = defaultAvatar,
            EmailConfirmed = true,
            DisplayNameColour = (DisplayNameColour)color,
        };

        await userManager.CreateAsync(newUser, request.Password);

        var userInfo = new UserInformationEntity { UserId = newUser.Id, CreatedAt = DateTime.UtcNow, };

        dbContext.UserInformation.Add(userInfo);

        var session = new SessionEntity
        {
            UserId = newUser.Id,
            RefreshToken = Guid.NewGuid(),
            ExpiresAt = DateTime.UtcNow.AddDays(jwtGeneratorSettings.MangoRefreshTokenLifetimeDays),
            CreatedAt = DateTime.UtcNow,
        };

        var accessToken = jwtGenerator.GenerateJwtToken(newUser);

        dbContext.Sessions.Add(session);

        var isMangoUserExists =
            await dbContext.Users.AnyAsync(x => x.Id == SeedDataConstants.MangoId, cancellationToken);

        if (isMangoUserExists == false)
        {
            // passwordHashService.HashPassword(mangoUser, mangoUserSettings.Password);
            // dbContext.Users.Add(mangoUser);
            await userManager.CreateAsync(mangoUser, mangoUserSettings.Password);
        }
        
        // var mangoChatEntity = new ChatEntity
        // {
        //     Id = Guid.NewGuid(),
        //     CommunityType = CommunityType.DirectChat,
        //     Title = "Mango Messenger",
        //     CreatedAt = DateTime.UtcNow,
        //     Description = "Service notifications",
        //     MembersCount = 2
        // };

        const string title = "Mango Messenger";
        const string description = "Service notifications";

        var mangoChatEntity = ChatEntity.Create(
            title,
            CommunityType.DirectChat,
            description,
            mangoUser.Image,
            DateTime.UtcNow,
            membersCount: 2);

        var senderChat = UserChatEntity.Create(newUser.Id, mangoChatEntity.Id, UserRole.User);
        var receiverChat = UserChatEntity.Create(userId: SeedDataConstants.MangoId, mangoChatEntity.Id, UserRole.User);

        var firstMessage = new MessageEntity
        {
            Id = Guid.NewGuid(),
            UserId = SeedDataConstants.MangoId,
            ChatId = mangoChatEntity.Id,
            Content = GreetingsConstants.Hello,
        };

        var secondMessage = new MessageEntity
        {
            Id = Guid.NewGuid(),
            UserId = SeedDataConstants.MangoId,
            ChatId = mangoChatEntity.Id,
            Content = GreetingsConstants.Guide,
        };

        // mangoChatEntity.LastMessageId = secondMessage.Id;
        // mangoChatEntity.LastMessageAuthor = mangoUser.DisplayName;
        // mangoChatEntity.LastMessageText = secondMessage.Content;
        // mangoChatEntity.LastMessageTime = secondMessage.CreatedAt;

        mangoChatEntity.UpdateLastMessage(
            lastMessageAuthor: mangoUser.DisplayName,
            lastMessageText: secondMessage.Content,
            secondMessage.CreatedAt,
            secondMessage.Id);

        dbContext.Chats.Add(mangoChatEntity);
        dbContext.UserChats.AddRange(senderChat, receiverChat);
        dbContext.Messages.AddRange(firstMessage, secondMessage);

        await dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();
        var userDisplayName = newUser.DisplayName;
        var userProfilePictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{newUser.Image}";

        var response = TokensResponse.FromSuccess(
            accessToken,
            session.RefreshToken,
            newUser.Id,
            expires,
            userDisplayName,
            userProfilePictureUrl,
            newUser.DisplayNameColour);
        var result = responseFactory.SuccessResponse(response);

        return result;
    }
}
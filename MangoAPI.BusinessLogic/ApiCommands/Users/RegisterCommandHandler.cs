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
using System.Security.Cryptography;
using System.Text;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<TokensResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<TokensResponse> responseFactory;
    private readonly IJwtGenerator jwtGenerator;
    private readonly IJwtGeneratorSettings jwtGeneratorSettings;
    private readonly IBlobServiceSettings blobServiceSettings;
    private readonly IMangoUserSettings mangoUserSettings;
    private readonly IAvatarService avatarService;

    public RegisterCommandHandler(
        MangoDbContext dbContext,
        IJwtGenerator jwtGenerator,
        IJwtGeneratorSettings jwtGeneratorSettings,
        ResponseFactory<TokensResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings,
        IMangoUserSettings mangoUserSettings,
        IAvatarService avatarService)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.jwtGenerator = jwtGenerator;
        this.jwtGeneratorSettings = jwtGeneratorSettings;
        this.blobServiceSettings = blobServiceSettings;
        this.mangoUserSettings = mangoUserSettings;
        this.avatarService = avatarService;
    }

    public async Task<Result<TokensResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var userExists = await dbContext.Users
            .AnyAsync(entity => entity.Username == request.Username, cancellationToken);

        if (userExists)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var color = new Random().Next(11);

        var defaultAvatar = avatarService.GetRandomAvatar();

        var hmac = new HMACSHA512();

        var newUser = new UserEntity
        {
            DisplayName = request.Username,
            Username = request.Username,
            Image = defaultAvatar,
            DisplayNameColour = (DisplayNameColour)color,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password)),
            PasswordSalt = hmac.Key
        };

        dbContext.Users.Add(newUser);

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

        var mangoUserExists =
            await dbContext.Users.AnyAsync(x => x.Id == SeedDataConstants.MangoId, cancellationToken);

        var mangoUser = GenerateMangoUser(mangoUserSettings.Password);

        if (mangoUserExists == false)
        {
            dbContext.Add(mangoUser);
        }

        var mangoChatEntity = CreateStarterChat(mangoUser);

        var senderChat = UserChatEntity.Create(newUser.Id, mangoChatEntity.Id, UserRole.User);
        var receiverChat = UserChatEntity.Create(userId: SeedDataConstants.MangoId, mangoChatEntity.Id, UserRole.User);

        var greetingMessages = GenerateGreetingMessages(mangoChatEntity);
        var lastMessage = greetingMessages[1];

        mangoChatEntity.UpdateLastMessage(
            lastMessageAuthor: mangoUser.DisplayName,
            lastMessageText: lastMessage.Content,
            lastMessage.CreatedAt,
            lastMessage.Id);

        dbContext.Chats.Add(mangoChatEntity);
        dbContext.UserChats.AddRange(senderChat, receiverChat);
        dbContext.Messages.AddRange(greetingMessages);

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

    private static ChatEntity CreateStarterChat(UserEntity mangoUser)
    {
        const string title = "Mango Messenger";
        const string description = "Service notifications";

        var mangoChatEntity = ChatEntity.Create(
            title,
            CommunityType.DirectChat,
            description,
            mangoUser.Image,
            DateTime.UtcNow,
            membersCount: 2);
        return mangoChatEntity;
    }

    private static MessageEntity[] GenerateGreetingMessages(ChatEntity mangoChatEntity)
    {
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

        var greetingMessages = new[] { firstMessage, secondMessage };

        return greetingMessages;
    }

    private static UserEntity GenerateMangoUser(string password)
    {
        var hmac = new HMACSHA512();

        var mangoUser = new UserEntity
        {
            DisplayName = "Mango Messenger",
            DisplayNameColour = DisplayNameColour.Violet,
            Bio = "Service notifications",
            Id = SeedDataConstants.MangoId,
            Username = "MangoMessenger",
            Image = "mango_logo.png",
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
            PasswordSalt = hmac.Key
        };

        return mangoUser;
    }
}
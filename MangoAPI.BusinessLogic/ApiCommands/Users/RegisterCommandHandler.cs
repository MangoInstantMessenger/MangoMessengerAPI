using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<TokensResponse>>
{
    private const string MangoSystemAccountUsername = "MangoMessenger";
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

        var hmac = new HMACSHA512();

        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password));
        var passwordSalt = hmac.Key;
        var displayName = request.Username;
        var imageFileName = avatarService.GetRandomAvatar();
        var displayColor = (DisplayNameColour)color;

        var newUser = UserEntity.Create(
            request.Username,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);
        
        newUser.UpdateBioAndLocation("Hello, I'm new here!", "Planet Earth");

        dbContext.Users.Add(newUser);

        var userInfo = PersonalInformationEntity.Create(newUser.Id);

        dbContext.PersonalInformation.Add(userInfo);

        var expiresAt = DateTime.UtcNow.AddDays(jwtGeneratorSettings.MangoRefreshTokenLifetimeDays);

        var session = SessionEntity.Create(newUser.Id, expiresAt);

        var accessToken = jwtGenerator.GenerateJwtToken(newUser);

        dbContext.Sessions.Add(session);

        var mangoSystemAcc =
            await dbContext.Users.FirstOrDefaultAsync(x => x.Username == MangoSystemAccountUsername, cancellationToken);

        if (mangoSystemAcc == null)
        {
            var mangoUser = GenerateMangoUser(mangoUserSettings.Password);
            dbContext.Add(mangoUser);
            mangoSystemAcc = mangoUser;
        }

        var systemChat = CreateSystemChat(mangoSystemAcc);

        var senderChat = UserChatEntity.Create(newUser.Id, systemChat.Id, UserRole.User);
        var receiverChat = UserChatEntity.Create(mangoSystemAcc.Id, systemChat.Id, UserRole.User);

        var greetingMessages = GenerateGreetingMessages(systemChat, mangoSystemAcc.Id);
        var lastMessage = greetingMessages[1];

        systemChat.UpdateLastMessage(
            lastMessageAuthor: mangoSystemAcc.DisplayName,
            lastMessageText: lastMessage.Text,
            lastMessage.CreatedAt,
            lastMessage.Id);

        dbContext.Chats.Add(systemChat);
        dbContext.UserChats.AddRange(senderChat, receiverChat);
        dbContext.Messages.AddRange(greetingMessages);

        await dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();
        var userDisplayName = newUser.DisplayName;
        var userProfilePictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{newUser.ImageFileName}";

        var response = TokensResponse.FromSuccess(
            accessToken,
            session.Id,
            newUser.Id,
            expires,
            userDisplayName,
            userProfilePictureUrl,
            newUser.DisplayNameColour);
        var result = responseFactory.SuccessResponse(response);

        return result;
    }

    private static ChatEntity CreateSystemChat(UserEntity mangoUser)
    {
        const string title = "Mango Messenger";
        const string description = "Service notifications";

        var mangoChatEntity = ChatEntity.Create(
            title,
            CommunityType.DirectChat,
            description,
            mangoUser.ImageFileName,
            DateTime.UtcNow,
            membersCount: 2);

        return mangoChatEntity;
    }

    private static MessageEntity[] GenerateGreetingMessages(ChatEntity chatEntity, Guid systemChatId)
    {
        var firstMessage = MessageEntity.Create(systemChatId, chatEntity.Id, GreetingsConstants.Hello);
        var secondMessage = MessageEntity.Create(systemChatId, chatEntity.Id, GreetingsConstants.Guide);

        var greetingMessages = new[] { firstMessage, secondMessage };

        return greetingMessages;
    }

    private static UserEntity GenerateMangoUser(string password)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }
}
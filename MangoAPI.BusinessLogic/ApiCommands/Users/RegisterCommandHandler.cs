using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<RegisterResponse>>
{
    private readonly IEmailSenderService emailSenderService;
    private readonly MangoDbContext dbContext;
    private readonly IUserManagerService userManager;
    private readonly ResponseFactory<RegisterResponse> responseFactory;
    private readonly IMailgunSettings mailgunSettings;

    public RegisterCommandHandler(
        IUserManagerService userManager,
        MangoDbContext dbContext,
        IEmailSenderService emailSenderService,
        ResponseFactory<RegisterResponse> responseFactory,
        IMailgunSettings mailgunSettings)
    {
        this.userManager = userManager;
        this.dbContext = dbContext;
        this.emailSenderService = emailSenderService;
        this.responseFactory = responseFactory;
        this.mailgunSettings = mailgunSettings;
    }

    public async Task<Result<RegisterResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var userExists = await dbContext.Users
            .AnyAsync(entity => entity.Email == request.Email, cancellationToken);

        if (userExists)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var notificationEmail = mailgunSettings.NotificationEmail;

        if (request.Email == notificationEmail)
        {
            const string errorMessage = ResponseMessageCodes.InvalidEmailAddress;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var random = new Random();

        var newUser = new UserEntity
        {
            DisplayName = request.DisplayName,
            UserName = Guid.NewGuid().ToString(),
            Email = request.Email,
            EmailCode = Guid.NewGuid(),
            Image = "default_avatar.png",
            DisplayNameColour = random.Next(0, 9),
        };

        await userManager.CreateAsync(newUser, request.Password);

        var userInfo = new UserInformationEntity
        {
            UserId = newUser.Id,
            CreatedAt = DateTime.UtcNow,
        };

        await emailSenderService.SendVerificationEmailAsync(newUser, cancellationToken);

        dbContext.UserInformation.Add(userInfo);

        await dbContext.SaveChangesAsync(cancellationToken);

        var response = RegisterResponse.FromSuccess(newUser.Id);
        var result = responseFactory.SuccessResponse(response);

        return result;
    }
}

using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<ResponseBase>>
{
    private readonly IEmailSenderService _emailSenderService;
    private readonly MangoDbContext _dbContext;
    private readonly IUserManagerService _userManager;
    private readonly ResponseFactory<ResponseBase> _responseFactory;
    private readonly IMailgunSettings _mailgunSettings;

    public RegisterCommandHandler(
        IUserManagerService userManager,
        MangoDbContext dbContext,
        IEmailSenderService emailSenderService,
        ResponseFactory<ResponseBase> responseFactory,
        IMailgunSettings mailgunSettings)
    {
        _userManager = userManager;
        _dbContext = dbContext;
        _emailSenderService = emailSenderService;
        _responseFactory = responseFactory;
        _mailgunSettings = mailgunSettings;
    }

    public async Task<Result<ResponseBase>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var userExists = await _dbContext.Users
            .AnyAsync(entity => entity.Email == request.Email, cancellationToken);

        if (userExists)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var notificationEmail = _mailgunSettings.NotificationEmail;

        if (request.Email == notificationEmail)
        {
            const string errorMessage = ResponseMessageCodes.InvalidEmailAddress;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var newUser = new UserEntity
        {
            DisplayName = request.DisplayName,
            UserName = Guid.NewGuid().ToString(),
            Email = request.Email,
            EmailCode = Guid.NewGuid(),
            Image = "default_avatar.png"
        };

        await _userManager.CreateAsync(newUser, request.Password);

        var userInfo = new UserInformationEntity
        {
            UserId = newUser.Id,
            CreatedAt = DateTime.UtcNow,
        };

        await _emailSenderService.SendVerificationEmailAsync(newUser, cancellationToken);

        _dbContext.UserInformation.Add(userInfo);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
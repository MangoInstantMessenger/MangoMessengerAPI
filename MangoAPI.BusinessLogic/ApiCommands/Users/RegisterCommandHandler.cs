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
    private readonly MangoDbContext dbContext;
    private readonly IUserManagerService userManager;
    private readonly ResponseFactory<RegisterResponse> responseFactory;

    public RegisterCommandHandler(
        IUserManagerService userManager,
        MangoDbContext dbContext,
        ResponseFactory<RegisterResponse> responseFactory)
    {
        this.userManager = userManager;
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
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

        var newUser = new UserEntity
        {
            DisplayName = request.DisplayName,
            UserName = Guid.NewGuid().ToString(),
            Email = request.Email,
            EmailCode = Guid.NewGuid(),
            Image = "default_avatar.png",
        };

        await userManager.CreateAsync(newUser, request.Password);

        var userInfo = new UserInformationEntity
        {
            UserId = newUser.Id,
            CreatedAt = DateTime.UtcNow,
        };

        dbContext.UserInformation.Add(userInfo);

        await dbContext.SaveChangesAsync(cancellationToken);

        var response = RegisterResponse.FromSuccess(newUser.Id);
        var result = responseFactory.SuccessResponse(response);

        return result;
    }
}

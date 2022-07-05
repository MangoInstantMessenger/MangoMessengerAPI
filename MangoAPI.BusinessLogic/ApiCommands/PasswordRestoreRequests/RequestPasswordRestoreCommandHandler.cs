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

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class RequestPasswordRestoreCommandHandler
    : IRequestHandler<RequestPasswordRestoreCommand, Result<RequestPasswordRestoreResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly IEmailSenderService emailSenderService;
    private readonly ResponseFactory<RequestPasswordRestoreResponse> responseFactory;

    public RequestPasswordRestoreCommandHandler(
        MangoDbContext dbContext,
        IEmailSenderService emailSenderService,
        ResponseFactory<RequestPasswordRestoreResponse> responseFactory)
    {
        this.dbContext = dbContext;
        this.emailSenderService = emailSenderService;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<RequestPasswordRestoreResponse>> Handle(
        RequestPasswordRestoreCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .FirstOrDefaultAsync(
                userEntity => userEntity.Email == request.Email,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var existingRequest = await dbContext.PasswordRestoreRequests
            .FirstOrDefaultAsync(entity => entity.UserId == user.Id, cancellationToken);

        if (existingRequest != null && existingRequest.IsValid)
        {
            const string errorMessage = ResponseMessageCodes.ChangePasswordRequestExists;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var passwordRestoreRequest = new PasswordRestoreRequestEntity
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            Email = user.Email,
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddHours(3),
        };

        dbContext.PasswordRestoreRequests.Add(passwordRestoreRequest);

        await dbContext.SaveChangesAsync(cancellationToken);

        await emailSenderService.SendPasswordRestoreRequestAsync(user, passwordRestoreRequest.Id, cancellationToken);

        var response = RequestPasswordRestoreResponse.FromSuccess(passwordRestoreRequest.Id);

        return responseFactory.SuccessResponse(response);
    }
}

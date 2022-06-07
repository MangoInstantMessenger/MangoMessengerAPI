using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class RequestPasswordRestoreCommandHandler
    : IRequestHandler<RequestPasswordRestoreCommand, Result<RequestPasswordRestoreResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly IEmailSenderService _emailSenderService;
    private readonly ResponseFactory<RequestPasswordRestoreResponse> _responseFactory;

    public RequestPasswordRestoreCommandHandler(MangoDbContext dbContext,
        IEmailSenderService emailSenderService, ResponseFactory<RequestPasswordRestoreResponse> responseFactory)
    {
        _dbContext = dbContext;
        _emailSenderService = emailSenderService;
        _responseFactory = responseFactory;
    }

    public async Task<Result<RequestPasswordRestoreResponse>> Handle(RequestPasswordRestoreCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(userEntity => userEntity.Email == request.Email,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var existingRequest = await _dbContext.PasswordRestoreRequests
            .FirstOrDefaultAsync(entity => entity.UserId == user.Id, cancellationToken);

        if (existingRequest != null && existingRequest.IsValid)
        {
            const string errorMessage = ResponseMessageCodes.ChangePasswordRequestExists;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var passwordRestoreRequest = new PasswordRestoreRequestEntity
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            Email = user.Email,
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddHours(3),
        };

        _dbContext.PasswordRestoreRequests.Add(passwordRestoreRequest);

        await _dbContext.SaveChangesAsync(cancellationToken);

        await _emailSenderService.SendPasswordRestoreRequestAsync(user, passwordRestoreRequest.Id, cancellationToken);

        var response = RequestPasswordRestoreResponse.FromSuccess(passwordRestoreRequest.Id);

        return _responseFactory.SuccessResponse(response);
    }
}
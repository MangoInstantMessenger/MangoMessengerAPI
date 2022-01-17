using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandHandler
        : IRequestHandler<UpdateProfilePictureCommand, Result<UpdateProfilePictureResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<UpdateProfilePictureResponse> _responseFactory;
        private readonly IBlobService _blobService;

        public UpdateProfilePictureCommandHandler(
            MangoPostgresDbContext postgresDbContext,
            ResponseFactory<UpdateProfilePictureResponse> responseFactory,
            IBlobService blobService)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
            _blobService = blobService;
        }

        public async Task<Result<UpdateProfilePictureResponse>> Handle(UpdateProfilePictureCommand request,
            CancellationToken cancellationToken)
        {
            var totalUploadedDocsCount = await _postgresDbContext.Documents.CountAsync(x =>
                x.UserId == request.UserId &&
                x.UploadedAt > DateTime.UtcNow.AddHours(-1), cancellationToken);

            if (totalUploadedDocsCount > 10)
            {
                const string message = ResponseMessageCodes.UploadedDocumentsLimitReached10;
                var details = ResponseMessageCodes.ErrorDictionary[message];
                return _responseFactory.ConflictResponse(message, details);
            }

            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(userEntity => userEntity.Id == request.UserId,
                    cancellationToken);

            if (user == null)
            {
                const string errorMessage = ResponseMessageCodes.UserNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var blobContainerName = EnvironmentConstants.MangoBlobContainer;
            var uniqueFileName = StringService.GetUniqueFileName(request.PictureFile.FileName);

            await _blobService.UploadFileBlobAsync(uniqueFileName, request.PictureFile, blobContainerName);

            var newUserPicture = new DocumentEntity
            {
                FileName = uniqueFileName,
                UserId = request.UserId,
                UploadedAt = DateTime.UtcNow
            };

            _postgresDbContext.Documents.Add(newUserPicture);

            user.Image = uniqueFileName;

            _postgresDbContext.Users.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var newUserPictureUrl = await _blobService.GetBlobAsync(uniqueFileName, blobContainerName);
            var response = UpdateProfilePictureResponse.FromSuccess(newUserPictureUrl);

            return _responseFactory.SuccessResponse(response);
        }
    }
}
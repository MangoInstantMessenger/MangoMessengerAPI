using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserInformation;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.UserInformation;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.UserInformation
{
    public class UpdateUserInformationCommandHandler : IRequestHandler<UpdateUserInformationCommand, UpdateUserInformationResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        
        public UpdateUserInformationCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<UpdateUserInformationResponse> Handle(UpdateUserInformationCommand request, CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var user = await _postgresDbContext.Users
                    .Include(x => x.UserInformation)
                    .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

                if (user is null)
                {
                    throw new BusinessException(ResponseMessageCodes.UserNotFound);
                }

                user.UserInformation.FirstName = request.FirstName;
                user.UserInformation.LastName = request.LastName;
                user.UserInformation.BirthDay = request.BirthDay;

                user.UserInformation.Website = request.Website;
                user.UserInformation.Address = request.Address;
            
                user.UserInformation.Facebook = request.Facebook;
                user.UserInformation.Twitter = request.Twitter;
                user.UserInformation.Instagram = request.Instagram;
                user.UserInformation.LinkedIn = request.LinkedIn;
            
                user.UserInformation.ProfilePicture = request.ProfilePicture;

                _postgresDbContext.UserInformation.Update(user.UserInformation);
                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return UpdateUserInformationResponse.SuccessResponse;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
        }
    }
}
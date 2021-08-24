using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, DeleteContactResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public DeleteContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }
        
        public async Task<DeleteContactResponse> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userContacts = await postgresDbContext.UserContacts
                .Where(x => x.UserId == request.UserId)
                .ToListAsync(cancellationToken);

            var contact = userContacts.FirstOrDefault(x => x.ContactId == request.ContactId);

            if (contact is null)
            {
                throw new BusinessException(ResponseMessageCodes.ContactNotFound);
            }

            postgresDbContext.UserContacts.Remove(contact);
            await postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return DeleteContactResponse.SuccessResponse;
        }
    }
}
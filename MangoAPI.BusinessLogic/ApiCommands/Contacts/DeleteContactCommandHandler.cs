using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, DeleteContactResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public DeleteContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<DeleteContactResponse> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userContacts = await _postgresDbContext.UserContacts.GetUserContactsAsync(user.Id, cancellationToken);

            var contact = userContacts.FirstOrDefault(x => x.ContactId == request.ContactId);

            if (contact is null)
            {
                throw new BusinessException(ResponseMessageCodes.ContactNotFound);
            }

            _postgresDbContext.UserContacts.Remove(contact);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return DeleteContactResponse.SuccessResponse;
        }
    }
}
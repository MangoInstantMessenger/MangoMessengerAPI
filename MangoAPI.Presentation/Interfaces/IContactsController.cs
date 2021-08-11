using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IContactsController
    {
        public Task<IActionResult> AddContact(AddContactRequest request, CancellationToken cancellationToken);
        public Task<IActionResult> GetContacts(CancellationToken cancellationToken);
    }
}
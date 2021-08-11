using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.Contacts;
using MangoAPI.DTO.ApiQueries.Contacts;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IContactsController
    {
        public Task<IActionResult> AddContact(AddContactRequest request, CancellationToken cancellationToken);
        public Task<IActionResult> GetContacts(CancellationToken cancellationToken);
    }
}
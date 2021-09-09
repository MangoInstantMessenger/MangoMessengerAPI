using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IContactsController
    {
        Task<IActionResult> AddContact(Guid contactId, CancellationToken cancellationToken);

        Task<IActionResult> DeleteContact(Guid contactId, CancellationToken cancellationToken);

        Task<IActionResult> GetContacts(CancellationToken cancellationToken);

        Task<IActionResult> SearchesAsync(string searchQuery, CancellationToken cancellationToken);
    }
}

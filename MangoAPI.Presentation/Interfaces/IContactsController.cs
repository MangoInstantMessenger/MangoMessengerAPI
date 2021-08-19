namespace MangoAPI.Presentation.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public interface IContactsController
    {
        public Task<IActionResult> AddContact(string contactId, CancellationToken cancellationToken);

        public Task<IActionResult> GetContacts(CancellationToken cancellationToken);
    }
}

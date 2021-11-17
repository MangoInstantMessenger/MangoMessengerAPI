using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IKeyExchangeController
    {
        public Task<IActionResult> GetKeyExchangeRequests(CancellationToken cancellationToken);

        public Task<IActionResult> CreteKeyExchangeRequest(CreateKeyExchangeRequest request,
            CancellationToken cancellationToken);

        public Task<IActionResult> ConfirmOrDeclineKeyExchangeRequest(ConfirmOrDeclineKeyExchangeRequest request,
            CancellationToken cancellationToken);
    }
}
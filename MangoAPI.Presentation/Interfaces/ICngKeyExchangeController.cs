using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface ICngKeyExchangeController
{
    public Task<IActionResult> CngGetKeyExchangeRequests(CancellationToken cancellationToken);

    public Task<IActionResult> CngCreteKeyExchangeRequest(CreateKeyExchangeRequest request,
        CancellationToken cancellationToken);

    public Task<IActionResult> CngConfirmOrDeclineKeyExchangeRequest(ConfirmOrDeclineKeyExchangeRequest request,
        CancellationToken cancellationToken);
}
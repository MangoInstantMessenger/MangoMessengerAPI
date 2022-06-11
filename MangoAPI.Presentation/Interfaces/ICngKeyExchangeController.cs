using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface ICngKeyExchangeController
{
    public Task<IActionResult> CngGetKeyExchangeRequests(CancellationToken cancellationToken);

    public Task<IActionResult> CngCreteKeyExchangeRequest(Guid receiverId, IFormFile senderPublicKey,
        CancellationToken cancellationToken);

    public Task<IActionResult> CngConfirmOrDeclineKeyExchangeRequest(CngConfirmOrDeclineKeyExchangeRequest request,
        CancellationToken cancellationToken);

    public Task<IActionResult> CngGetKeyExchangeRequestById(Guid requestId, CancellationToken cancellationToken);
}
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface IKeyExchangeController
{
    public Task<IActionResult> OpenSslCreateDiffieHellmanParameter(IFormFile file, CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslGetDiffieHellmanParameter(CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslCreateKeyExchangeRequest(Guid userId, IFormFile senderPublicKey,
        CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslGetKeyExchangeRequests(CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslConfirmKeyExchangeRequest(
        Guid requestId,
        IFormFile receiverPublicKey,
        CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslDeclineKeyExchangeRequest(Guid requestId, CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslDownloadPartnerPublicKey(Guid requestId,
        CancellationToken cancellationToken);

    public Task<IActionResult> CngGetKeyExchangeRequests(CancellationToken cancellationToken);

    public Task<IActionResult> CngCreteKeyExchangeRequest(CreateKeyExchangeRequest request,
        CancellationToken cancellationToken);

    public Task<IActionResult> CngConfirmOrDeclineKeyExchangeRequest(ConfirmOrDeclineKeyExchangeRequest request,
        CancellationToken cancellationToken);
}
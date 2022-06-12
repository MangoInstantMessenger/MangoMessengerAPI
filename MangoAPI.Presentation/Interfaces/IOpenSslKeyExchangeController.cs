using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface IOpenSslKeyExchangeController
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

    public Task<IActionResult> OpenSslDownloadPartnerPublicKey(Guid requestId, CancellationToken cancellationToken);

    public Task<IActionResult> OpenSslGetKeyExchangeRequestById(Guid requestId, CancellationToken cancellationToken);
}
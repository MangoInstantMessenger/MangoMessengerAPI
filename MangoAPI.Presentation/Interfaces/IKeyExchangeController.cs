using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface IKeyExchangeController
{
    public Task<IActionResult> CreateDiffieHellmanParameter(IFormFile file, CancellationToken cancellationToken);
    public Task<IActionResult> DownloadDiffieHellmanParameter(CancellationToken cancellationToken);

    public Task<IActionResult> CreateKeyExchangeRequest(Guid userId, IFormFile senderPublicKey,
        CancellationToken cancellationToken);

    public Task<IActionResult> GetKeyExchangeRequests(CancellationToken cancellationToken);

    public Task<IActionResult> ConfirmKeyExchangeRequest(
        Guid requestId,
        IFormFile receiverPublicKey,
        CancellationToken cancellationToken);

    public Task<IActionResult> DeclineKeyExchangeRequest(Guid requestId, CancellationToken cancellationToken);

    public Task<IActionResult> DownloadPartnerPublicKey(Guid requestId, CancellationToken cancellationToken);

    public Task<IActionResult> GetKeyExchangeRequestById(Guid requestId, CancellationToken cancellationToken);
}
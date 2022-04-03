using System;

namespace MangoAPI.Domain.Entities;

public class OpenSslKeyExchangeRequestEntity
{
    public Guid Id { get; set; }
    public Guid SenderId { get; set; }
    public Guid ReceiverId { get; set; }
    public byte[] SenderPublicKey { get; set; }
    public byte[] ReceiverPublicKey { get; set; }
    public bool IsConfirmed { get; set; }
}
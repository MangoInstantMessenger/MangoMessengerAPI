using System;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models;

public record OpenSslKeyExchangeRequest
{
    public Guid RequestId { get; init; }
    public Guid SenderId { get; init; }
    public Guid ReceiverId { get; init; }
    public bool IsConfirmed { get; init; }
    public Actor Actor { get; init; }

    public KeyExchangeType KeyExchangeType { get; set; }

    public override string ToString()
    {
        return
            $"Request Id: {RequestId}, \n" +
            $"Sender Id: {SenderId}, \n" +
            $"Receiver Id: {ReceiverId}, \n" +
            $"Confirmed: {IsConfirmed}, \n" +
            $"Actor: {Actor} \n" +
            $"KeyExchangeType: {KeyExchangeType} \n";
    }
}

public enum Actor
{
    /// <summary>
    /// Request sender
    /// </summary>
    Sender = 1,

    /// <summary>
    /// Request receiver
    /// </summary>
    Receiver = 2
}
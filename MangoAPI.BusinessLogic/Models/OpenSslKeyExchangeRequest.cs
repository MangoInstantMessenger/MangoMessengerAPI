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
            $"Actor: {Actor.ToString()} \n " +
            $"KeyExchangeType: {KeyExchangeType.ToString()}";
    }
}

public enum Actor
{
    Sender = 1,
    Receiver = 2,
}
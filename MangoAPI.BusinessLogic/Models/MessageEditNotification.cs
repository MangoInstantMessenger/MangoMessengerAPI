using System;

namespace MangoAPI.BusinessLogic.Models;

public class MessageEditNotification
{
    public Guid MessageId { get; init; }

    public string ModifiedText { get; init; }

    public DateTime UpdatedAt { get; init; }

    public bool IsLastMessage { get; init; }
}
using System;

namespace MangoAPI.Application.Interfaces;

public interface ICorrelationContext
{
    public Guid GetUserId();

    public string GetUserName();
}
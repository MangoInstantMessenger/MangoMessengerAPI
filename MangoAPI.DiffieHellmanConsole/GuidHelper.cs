using System;

namespace MangoAPI.DiffieHellmanConsole;

public static class GuidHelper
{
    public static Guid GetGuidValue(string guidAsString)
    {
        var isParsed = Guid.TryParse(guidAsString, out var guid);

        if (!isParsed)
        {
            throw new InvalidCastException("ReceiverId is not a valid Guid.");
        }

        return guid;
    }
}
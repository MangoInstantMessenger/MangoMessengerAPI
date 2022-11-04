using System;
using System.Runtime.Serialization;

namespace MangoAPI.Infrastructure.Exceptions;

[Serializable]
public class AppSettingException : Exception
{
    protected AppSettingException(SerializationInfo serializationInfo, StreamingContext streamingContext) :
        base(serializationInfo, streamingContext)
    {
    }

    public AppSettingException(string message) : base($"App setting variable does not exist: {message}.")
    {
    }
}

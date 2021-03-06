using System;
using System.Runtime.Serialization;

namespace MangoAPI.Infrastructure.Exceptions;

[Serializable]
public class EnvironmentVariableException : Exception
{
    protected EnvironmentVariableException(SerializationInfo serializationInfo, StreamingContext streamingContext) :
        base(serializationInfo, streamingContext)
    {
    }

    public EnvironmentVariableException(string message) : base($"Environment variable does not exist: {message}.")
    {
    }
}
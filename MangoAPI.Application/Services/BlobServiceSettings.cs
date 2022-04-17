using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class BlobServiceSettings : IBlobServiceSettings
{
    public BlobServiceSettings(string mangoBlobContainerName, string mangoBlobAccess)
    {
        MangoBlobContainerName = mangoBlobContainerName;
        MangoBlobAccess = mangoBlobAccess;
    }
    
    public string MangoBlobContainerName { get; }
    public string MangoBlobAccess { get; }
}
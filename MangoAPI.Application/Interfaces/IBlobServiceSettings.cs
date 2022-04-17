namespace MangoAPI.Application.Interfaces;

public interface IBlobServiceSettings
{
    string MangoBlobContainerName { get; }
    string MangoBlobAccess { get; }
}
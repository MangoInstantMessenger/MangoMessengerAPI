namespace MangoAPI.Application.Interfaces;

public interface IBlobServiceSettings
{
    string MangoBlobContainerName { get; }

    // http://127.0.0.1:10000/devstoreaccount1/testcontainer
    string MangoBlobAccess { get; }
}
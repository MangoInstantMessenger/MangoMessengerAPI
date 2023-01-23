using Azure.Storage.Blobs;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AzureBlobDependencyInjection
{
    public static IServiceCollection AddAzureBlobServices(
        this IServiceCollection services,
        string mangoBlobUrl,
        string mangoBlobContainerName,
        string mangoBlobAccess)
    {
        var blobClient = new BlobServiceClient(mangoBlobUrl);

        var mangoBlobService = new BlobServiceSettings(mangoBlobContainerName, mangoBlobAccess);

        _ = services.AddSingleton(_ => blobClient);

        _ = services.AddSingleton<IBlobServiceSettings, BlobServiceSettings>(_ => mangoBlobService);

        _ = services.AddScoped<IBlobService, BlobService>(_ => new BlobService(blobClient, mangoBlobService));

        return services;
    }
}

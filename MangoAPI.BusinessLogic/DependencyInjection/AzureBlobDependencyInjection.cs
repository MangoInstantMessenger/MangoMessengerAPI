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
        string mangoBlobAccess,
        IBlobService blobServiceMock = null)
    {
        if (blobServiceMock != null)
        {
            services.AddScoped(_ => blobServiceMock);
            return services;
        }

        var blobClient = new BlobServiceClient(mangoBlobUrl);

        var mangoBlobService = new BlobServiceSettings(mangoBlobContainerName, mangoBlobAccess);

        services.AddSingleton(_ => blobClient);

        services.AddSingleton<IBlobServiceSettings, BlobServiceSettings>(_ => mangoBlobService);

        services.AddScoped<IBlobService, BlobService>(_ => new BlobService(blobClient, mangoBlobService));

        return services;
    }
}
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AzureBlobInitializer
{
    public static void InitializeAzureBlob(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        var blobClient = serviceScope.ServiceProvider.GetService<BlobServiceClient>();
        var blobServiceSettings = serviceScope.ServiceProvider.GetService<IBlobServiceSettings>();

        var containerClient = blobClient.GetBlobContainerClient(blobServiceSettings.MangoBlobContainerName);
        containerClient.CreateIfNotExists();
        containerClient.SetAccessPolicy(PublicAccessType.BlobContainer);

        var files = Directory.GetFiles(Path.Combine(AppContext.BaseDirectory, "../../../../img/seed_images"));
        foreach (var filePath in files)
        {
            var fileName = filePath.Split(@"\")[^1];
            var client = containerClient.GetBlobClient(fileName);
            var result = client.Exists();
            if (result.Value)
            {
                continue;
            }

            using var stream = File.OpenRead(filePath);

            var headers = new BlobHttpHeaders { ContentType = "image/jpg" };
            client.Upload(stream, headers);
        }
    }
}
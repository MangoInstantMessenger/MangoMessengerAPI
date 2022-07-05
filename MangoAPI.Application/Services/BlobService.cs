using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class BlobService : IBlobService
{
    private readonly BlobServiceClient blobClient;
    private readonly IBlobServiceSettings blobServiceSettings;

    public BlobService(BlobServiceClient blobClient, IBlobServiceSettings blobServiceSettings)
    {
        this.blobClient = blobClient;
        this.blobServiceSettings = blobServiceSettings;
    }

    public Task<string> GetBlobAsync(string fileName)
    {
        var containerClient = this.blobClient.GetBlobContainerClient(blobServiceSettings.MangoBlobContainerName);
        var blobClient = containerClient.GetBlobClient(fileName);

        return Task.FromResult(blobClient.Uri.AbsoluteUri);
    }

    public async Task<bool> UploadFileBlobAsync(Stream stream, string contentType, string uniqueName)
    {
        var blobContainerName = blobServiceSettings.MangoBlobContainerName;
        var containerClient = GetContainerClient(blobContainerName);
        var blobClient = containerClient.GetBlobClient(uniqueName);
        var headers = new BlobHttpHeaders { ContentType = contentType };
        var result = await blobClient.UploadAsync(stream, headers);

        return result.Value != null;
    }

    public async Task<bool> DeleteBlobAsync(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentNullException(nameof(fileName));
        }

        var containerClient = this.blobClient.GetBlobContainerClient(blobServiceSettings.MangoBlobContainerName);
        var blobClient = containerClient.GetBlobClient(fileName);

        var result = await blobClient.DeleteIfExistsAsync();

        return result.Value;
    }

    private BlobContainerClient GetContainerClient(string blobContainerName)
    {
        var containerClient = blobClient.GetBlobContainerClient(blobContainerName);
        containerClient.CreateIfNotExists();
        return containerClient;
    }
}

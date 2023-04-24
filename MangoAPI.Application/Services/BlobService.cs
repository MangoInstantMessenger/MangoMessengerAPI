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

    public async Task<string> GetBlobUrlAsync(string fileName)
    {
        var containerClient = await GetContainerClientAsync(blobServiceSettings.MangoBlobContainerName);
        var client = containerClient.GetBlobClient(fileName);

        var blobExists = await client.ExistsAsync();

        if (!blobExists.Value)
        {
            throw new FileNotFoundException("Blob file was not found at storage account.");
        }

        var blobUrl = $"{blobServiceSettings.MangoBlobAccess}/{fileName}";

        return blobUrl;
    }

    public async Task<bool> UploadFileBlobAsync(Stream stream, string contentType, string uniqueName)
    {
        var blobContainerName = blobServiceSettings.MangoBlobContainerName;

        var containerClient = await GetContainerClientAsync(blobContainerName);

        var client = containerClient.GetBlobClient(uniqueName);

        var headers = new BlobHttpHeaders { ContentType = contentType };
        var result = await client.UploadAsync(stream, headers);

        return result.Value != null;
    }

    public async Task<bool> DeleteBlobAsync(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentNullException(nameof(fileName));
        }

        var containerClient = blobClient.GetBlobContainerClient(blobServiceSettings.MangoBlobContainerName);
        var client = containerClient.GetBlobClient(fileName);

        var result = await client.DeleteIfExistsAsync();

        return result.Value;
    }

    public bool UploadFolderToBlob(string folderPath)
    {
        var containerClient = GetContainerClient(blobServiceSettings.MangoBlobContainerName);

        var combinePath = Path.Combine(AppContext.BaseDirectory, folderPath);

        var files = Directory.GetFiles(combinePath);

        foreach (var file in files)
        {
            var fileName = Path.GetFileName(file);

            var client = containerClient.GetBlobClient(fileName);

            var fileExists = client.Exists();

            if (fileExists.Value)
            {
                continue;
            }

            using var stream = File.OpenRead(file);

            var headers = new BlobHttpHeaders { ContentType = "image/jpg" };

            client.Upload(stream, headers);
        }

        return true;
    }

    private async Task<BlobContainerClient> GetContainerClientAsync(string blobContainerName)
    {
        var containerClient = blobClient.GetBlobContainerClient(blobContainerName);

        await containerClient.CreateIfNotExistsAsync();

        await containerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

        return containerClient;
    }

    private BlobContainerClient GetContainerClient(string blobContainerName)
    {
        var containerClient = blobClient.GetBlobContainerClient(blobContainerName);

        containerClient.CreateIfNotExists();

        containerClient.SetAccessPolicy(PublicAccessType.BlobContainer);

        return containerClient;
    }
}
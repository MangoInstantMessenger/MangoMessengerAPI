using System;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Services;

public class BlobService : IBlobService
{
    private readonly BlobServiceClient _blobClient;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public BlobService(BlobServiceClient blobClient, IBlobServiceSettings blobServiceSettings)
    {
        _blobClient = blobClient;
        _blobServiceSettings = blobServiceSettings;
    }

    public Task<string> GetBlobAsync(string name)
    {
        var containerClient = _blobClient.GetBlobContainerClient(_blobServiceSettings.MangoBlobContainerName);
        var blobClient = containerClient.GetBlobClient(name);
        
        return Task.FromResult(blobClient.Uri.AbsoluteUri);
    }

    public async Task<bool> UploadFileBlobAsync(string name, IFormFile file)
    {
        try
        {
            var containerClient = _blobClient.GetBlobContainerClient(_blobServiceSettings.MangoBlobContainerName);

            var blobClient = containerClient.GetBlobClient(name);

            var httpHeaders = new BlobHttpHeaders
            {
                ContentType = file.ContentType
            };

            var blobInfo = await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);

            if (blobInfo != null)
            {
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return false;
    }
}
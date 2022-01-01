using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Services
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobClient;

        public BlobService(BlobServiceClient blobClient)
        {
            _blobClient = blobClient;
        }

        public Task<string> GetBlobAsync(string name, string containerName)
        {
            var containerClient = _blobClient.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(name);

            var str = blobClient.Uri.AbsoluteUri;

            return Task.FromResult(str);
        }

        public async Task<IEnumerable<string>> AllBlobsAsync(string containerName)
        {
            var containerClient = _blobClient.GetBlobContainerClient(containerName);
            var files = new List<string>();

            var blobs = containerClient.GetBlobsAsync();
            
            await foreach (var item in blobs)
            {
                files.Add(item.Name);
            }

            return files;
        }

        public async Task<bool> UploadFileBlobAsync(string name, IFormFile file, string containerName)
        {
            try
            {
                var containerClient = _blobClient.GetBlobContainerClient(containerName);
                
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

        public async Task<bool> DeleteBlobAsync(string name, string containerName)
        {
            var containerClient = _blobClient.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(name);
            return await blobClient.DeleteIfExistsAsync();
        }
    }
}
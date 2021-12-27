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
            // In order for us to get access to anything inside our blob 
            // We first need to connect to the blob container 
            // and then we need to get the container client which referes to the 
            // specific container we want to access

            // This will me to access data inside the personal container
            var containerClient = _blobClient.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(name);

            var str = blobClient.Uri.AbsoluteUri;

            return Task.FromResult(str);
        }

        public async Task<IEnumerable<string>> AllBlobsAsync(string containerName)
        {
            // This will me to access data inside the personal container
            var containerClient = _blobClient.GetBlobContainerClient(containerName);
            var files = new List<string>();

            var blobs = containerClient.GetBlobsAsync();

            // We are awaiting a foreach here as the 
            // blobs are streamable objects we need to wait until they are available
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

                // The idea of getting a reference to a blob client which doesnt exist 
                // is the way Azure blobs are implemented, we initiate these client 
                // and then we do checks if actually exist or not and then we can perform
                // any action we want upload, delete ...
                var blobClient = containerClient.GetBlobClient(name);
                //var blobClient1 = containerClient.GetBlobClient("1"+name);

                var httpHeaders = new BlobHttpHeaders
                {
                    ContentType = file.ContentType
                };

                var blobInfo = await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);

                if (blobInfo != null)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public async Task<bool> DeleteBlobAsync(string name, string containerName)
        {
            // This will me to access data inside the personal container
            var containerClient = _blobClient.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(name);
            return await blobClient.DeleteIfExistsAsync();
        }
    }
}
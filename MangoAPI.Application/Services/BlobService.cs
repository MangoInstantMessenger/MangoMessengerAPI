using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
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

        public Task<string> GetBlob(string name, string containerName)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<string>> AllBlobs(string containerName)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UploadFileBlob(string name, IFormFile file, string containerName)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteBlob(string name, string containerName)
        {
            throw new System.NotImplementedException();
        }
    }
}
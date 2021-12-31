using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Interfaces
{
    public interface IBlobService
    {
        Task<string> GetBlobAsync(string name, string containerName);
        
        Task<IEnumerable<string>> AllBlobsAsync(string containerName);
        
        Task<bool> UploadFileBlobAsync(string name, IFormFile file, string containerName);
        
        Task<bool> DeleteBlobAsync(string name, string containerName);
    }
}
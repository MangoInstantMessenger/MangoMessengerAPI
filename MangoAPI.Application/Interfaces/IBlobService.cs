using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Interfaces
{
    public interface IBlobService
    {
        Task<string> GetBlobAsync(string name, string containerName);

        Task<bool> UploadFileBlobAsync(string name, IFormFile file, string containerName);
    }
}
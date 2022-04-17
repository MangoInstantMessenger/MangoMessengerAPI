using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Application.Interfaces;

public interface IBlobService
{
    Task<string> GetBlobAsync(string name);

    Task<bool> UploadFileBlobAsync(string name, IFormFile file);
}
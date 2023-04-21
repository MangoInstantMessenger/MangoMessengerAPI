using System.IO;
using System.Threading.Tasks;

namespace MangoAPI.Application.Interfaces;

public interface IBlobService
{
    Task<bool> BlobExistsAsync(string fileName);
    
    Task<string> GetBlobAsync(string fileName);

    Task<bool> UploadFileBlobAsync(Stream stream, string contentType, string uniqueName);

    Task<bool> DeleteBlobAsync(string fileName);
}
using System.IO;
using System.Threading.Tasks;

namespace MangoAPI.Application.Interfaces;

public interface IBlobService
{
    Task<string> GetBlobUrlAsync(string fileName);

    Task<bool> UploadFileBlobAsync(Stream stream, string contentType, string uniqueName);

    Task<bool> DeleteBlobAsync(string fileName);

    bool UploadFolderToBlob(string folderPath);
}
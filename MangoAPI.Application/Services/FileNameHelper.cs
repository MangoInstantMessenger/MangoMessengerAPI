using System;
using System.IO;

namespace MangoAPI.Application.Services;

public static class FileNameHelper
{
    /// <summary>
    /// Generates unique file name adding guid to its name.
    /// </summary>
    public static string CreateUniqueFileName(string fileName)
    {
        var newFileName = Path.GetFileName(fileName);
        var extension = Path.GetExtension(newFileName);
        var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(newFileName);
        var fileGuid = Guid.NewGuid();

        var result = $"{fileNameWithoutExtension}_{fileGuid}{extension}";

        return result;
    }
}
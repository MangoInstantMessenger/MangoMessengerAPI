using System.IO;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.IntegrationTests.Helpers;

public static class MangoFilesHelper
{
    private const string FilePath = "../../../Files/main_ava.jpg";
    private const string FileName = "main_ava.jpg";

    public static IFormFile GetTestImage()
    {
        var stream = File.OpenRead(FilePath);

        var file = new FormFile(
            stream,
            baseStreamOffset: 0,
            stream.Length,
            name: FileName,
            Path.GetFileName(stream.Name));

        return file;
    }
}
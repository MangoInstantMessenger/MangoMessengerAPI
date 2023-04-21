using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AzureBlobInitializer
{
    public static async Task InitializeAzureBlobAsync(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        var blobService = serviceScope.ServiceProvider.GetService<IBlobService>();

        var files = Directory.GetFiles(Path.Combine(AppContext.BaseDirectory, "../../../../img/seed_images"));
        foreach (var filePath in files)
        {
            var fileName = filePath.Split(@"\")[^1];
            var result = await blobService.BlobExistsAsync(fileName);
            if (result)
            {
                continue;
            }

            await using var stream = File.OpenRead(filePath);
            var file = new FormFile(
                baseStream: stream,
                baseStreamOffset: 0,
                length: stream.Length,
                name: "qwerty",
                fileName: fileName)
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/jpg"
            };

            await blobService.UploadFileBlobAsync(file.OpenReadStream(), file.ContentType, fileName);
        }
    }
}
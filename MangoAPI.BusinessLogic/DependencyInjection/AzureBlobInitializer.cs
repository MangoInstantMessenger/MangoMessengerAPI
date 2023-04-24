using MangoAPI.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AzureBlobInitializer
{
    private const string SeedImagesFolder = "../../../../img/seed_images";

    public static void InitializeAzureBlob(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        var blobService = serviceScope.ServiceProvider.GetService<IBlobService>();

        blobService.UploadFolderToBlob(SeedImagesFolder);
    }
}
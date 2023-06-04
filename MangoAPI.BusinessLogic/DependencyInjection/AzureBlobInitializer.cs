using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AzureBlobInitializer
{
    public static void InitializeAzureBlob(this IApplicationBuilder app, IConfiguration configuration)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        var blobService = serviceScope.ServiceProvider.GetService<IBlobService>();

        var seedImagesFolder = configuration[EnvironmentConstants.SeedImagesFolder];

        blobService.UploadFolderToBlob(seedImagesFolder);
    }
}
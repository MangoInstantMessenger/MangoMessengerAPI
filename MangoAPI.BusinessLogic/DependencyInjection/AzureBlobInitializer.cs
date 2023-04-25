using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AzureBlobInitializer
{
    private const string SeedImagesFolder = "../../../../img/seed_images";
    private const string SeedImagesFolderWithinDockerContainer = "img/seed_images";

    public static void InitializeAzureBlob(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        var blobService = serviceScope.ServiceProvider.GetService<IBlobService>();

        var runningInContainerEnvValue = Environment.GetEnvironmentVariable(EnvironmentConstants.AspNetCoreRunningInContainer);

        var result = bool.TryParse(runningInContainerEnvValue, out var isRunningInContainer);

        if (result && isRunningInContainer)
        {
            blobService.UploadFolderToBlob(SeedImagesFolderWithinDockerContainer);
            return;
        }

        blobService.UploadFolderToBlob(SeedImagesFolder);
    }
}
using MangoAPI.BusinessLogic;
using MangoAPI.Domain;
using Microsoft.Extensions.DependencyInjection;
using OpenAI_API;
using System;
using System.Net;
using System.Net.Http;

namespace MangoAPI.Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddChatGPTClient(
        this IServiceCollection services,
        ChatGPTOptions chatGptOptions)
    {
        return chatGptOptions is null
            ? throw new ArgumentNullException(nameof(chatGptOptions))
            : services
            .AddSingleton(chatGptOptions)
            .AddScoped<IChatGPTAdapter, ChatGptAdapter>()
            .AddSingleton(_ => new OpenAIAPI(new APIAuthentication(
                chatGptOptions.APIKey, chatGptOptions.OrganizationId)));
    }
}
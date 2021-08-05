using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.ApiCommands.Chats;
using MangoAPI.DTO.ApiCommands.Contacts;
using MangoAPI.DTO.ApiCommands.Messages;
using MangoAPI.DTO.ApiQueries.Chats;
using MangoAPI.DTO.ApiQueries.Messages;
using MangoAPI.DTO.ApiQueries.Users;
using MangoAPI.Infrastructure.Pipelines;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Infrastructure.StartupExtensions
{
    public static class InfraExtension
    {
        public static IServiceCollection AddAppInfrastructure(this IServiceCollection services)
        {
            services.AddPostgresDb();
            services.AddIdentityUsers();
            services.AddAppServices();
            services.AddAppAuthorization();
            services.AddAppAuthentication();
            services.AddValidatorsFromAssembly(typeof(InfraExtension).Assembly);
            
            // Auth Validators
            services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(RegisterCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(VerifyEmailCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(VerifyPhoneCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(RefreshTokenCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(LogoutCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(LogoutAllCommandValidator).Assembly);
            
            // Chat Validators
            services.AddValidatorsFromAssembly(typeof(CreateDirectChatCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(CreateGroupCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(JoinChatCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(SearchChatsQueryValidator).Assembly);

            // Message Validators
            services.AddValidatorsFromAssembly(typeof(DeleteMessageCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(EditMessageCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(SendMessageCommandValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(GetMessagesQueryValidator).Assembly);

            // User Validators
            services.AddValidatorsFromAssembly(typeof(GetCurrentUserChatsQueryValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(GetUserQueryValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(UserSearchQueryValidator).Assembly);
            
            // Contacts Validators
            services.AddValidatorsFromAssembly(typeof(AddContactCommandValidator).Assembly);

            // User Information Validators
            services.AddValidatorsFromAssembly(typeof(UserSearchQueryValidator).Assembly);

            
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}
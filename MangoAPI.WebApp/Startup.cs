using System;
using System.Text;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.CommandHandlers;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MangoAPI.Infrastructure.Services;
using MangoAPI.Infrastructure.Validators;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace MangoAPI.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        private IConfiguration Configuration { get; }

        public static void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("POSTGRES_MANGO_CONNECTION_STRING");
            var tokenKey = Environment.GetEnvironmentVariable("MANGO_TOKEN_KEY");
            var issuer = Environment.GetEnvironmentVariable("MANGO_ISSUER");
            var audience = Environment.GetEnvironmentVariable("MANGO_AUDIENCE");

            services.AddControllers();
            services.AddDbContext<MangoPostgresDbContext>(opt =>
                opt.UseNpgsql(connectionString ??
                              throw new InvalidOperationException("Wrong Connection String in Startup class.")));


            var builder = services.AddIdentityCore<UserEntity>();
            var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);
            identityBuilder.AddEntityFrameworkStores<MangoPostgresDbContext>();
            identityBuilder.AddSignInManager<SignInManager<UserEntity>>();

            services.AddMediatR(typeof(RegisterCommandHandler).Assembly);

            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<ICookieService, CookieService>();
            services.AddScoped<ISecurityTokenValidator, JwtSecurityTokenValidator>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey!));

            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, configure =>
                {
                    configure.RequireHttpsMetadata = false;
                    configure.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = issuer,
                        ValidateIssuer = true,
                        ValidAudience = audience,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        IssuerSigningKey = signingKey,
                        ValidateIssuerSigningKey = true
                    };
                });

            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "MangoAPI", Version = "v1"}); });
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MangoAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                                   ForwardedHeaders.XForwardedProto
            });
        }
    }
}
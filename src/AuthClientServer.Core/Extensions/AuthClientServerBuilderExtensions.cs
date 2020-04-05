namespace AuthClientServer.Core
{
    using AuthClientServer.Storage;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public static class AuthClientServerBuilderExtensions
    {
        public static IAuthClientServerBuilder AddStorage<TContext>(this IAuthClientServerBuilder builder, Action<DbContextOptionsBuilder> options)
            where TContext : AuthClientServerDbContext
        {
            builder.Services.AddDbContext<TContext>(options);
            builder.Services.AddScoped<IClientStorage, ClientStorage>();
            builder.Services.AddScoped<IResourceStorage, ResourceStorage>();
            return builder;
        }
    }
}


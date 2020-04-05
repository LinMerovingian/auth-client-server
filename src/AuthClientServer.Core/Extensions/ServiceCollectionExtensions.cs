namespace AuthClientServer.Core
{
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IAuthClientServerBuilder AddAuthClientServer(this IServiceCollection services)
        {
            return new AuthClientServerBuilder(services);
        }
    }
}

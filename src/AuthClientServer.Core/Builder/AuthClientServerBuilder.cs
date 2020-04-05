namespace AuthClientServer.Core
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class AuthClientServerBuilder : IAuthClientServerBuilder
    {
        public IServiceCollection Services { get; }
        public AuthClientServerBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }
    }
}

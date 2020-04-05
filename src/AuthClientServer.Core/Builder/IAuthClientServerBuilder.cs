namespace AuthClientServer.Core
{
    using Microsoft.Extensions.DependencyInjection;

    public interface IAuthClientServerBuilder
    {
        IServiceCollection Services { get; }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Template.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            return services;
        }
    }
}

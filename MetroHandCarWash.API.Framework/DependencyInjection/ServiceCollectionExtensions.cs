using Microsoft.Extensions.DependencyInjection;
using MetroHandCarWash.API.Framework.Command;
using MetroHandCarWash.API.Framework.Query;

namespace MetroHandCarWash.API.Framework.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterQueryProcessor(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddTransient<IQueryProcessor, QueryProcessor>();
        }
        public static IServiceCollection RegisterCommandBus(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddTransient<ICommandBus, CommandBus>();
        }
    }
}

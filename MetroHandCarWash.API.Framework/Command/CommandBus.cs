using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MetroHandCarWash.API.Framework.Command
{
    internal class CommandBus : ICommandBus
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandBus(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task<TResult> ExecuteAsync<TContext, TResult>(TContext context)
        {
            return await Task.Run(() => _serviceProvider.GetRequiredService<ICommandHandler<TContext, TResult>>().Handle(context));
        }
    }
}

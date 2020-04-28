using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MetroHandCarWash.API.Framework.Query
{
    internal class QueryProcessor : IQueryProcessor
    {
        private readonly IServiceProvider _serviceProvider;

        public QueryProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<TResult> ProcessQueryAsync<TInput, TResult>(TInput input) where TInput : IQueryInput where TResult : IQueryResult
        {
            return await _serviceProvider.GetRequiredService<IQueryHandler<TInput, TResult>>().RunQuery(input);
        }
    }
}

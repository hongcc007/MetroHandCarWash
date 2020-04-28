using System.Threading.Tasks;

namespace MetroHandCarWash.API.Framework.Query
{
    public interface IQueryProcessor
    {
        // TResult ProcessQuery<TInput, TResult>(TInput input) where TResult : IQueryResult where TInput : IQueryInput;
        Task<TResult> ProcessQueryAsync<TInput, TResult>(TInput input) where TResult : IQueryResult where TInput : IQueryInput;
    }
}

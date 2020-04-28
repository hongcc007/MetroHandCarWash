using System.Threading.Tasks;


namespace MetroHandCarWash.API.Framework.Query
{
    public interface IQueryHandler<TInput, TResult> where TInput : IQueryInput where TResult : IQueryResult
    {
        Task<TResult> RunQuery(TInput input);
    }
}

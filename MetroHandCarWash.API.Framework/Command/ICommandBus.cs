using System.Threading.Tasks;

namespace MetroHandCarWash.API.Framework.Command
{
    public interface ICommandBus
    {
        //TResult Execute<TContext, TResult>(TContext context);
        Task<TResult> ExecuteAsync<TContext, TResult>(TContext context);
    }
}

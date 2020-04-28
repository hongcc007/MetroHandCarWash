using System.Threading.Tasks;
namespace MetroHandCarWash.API.Framework.Command
{
    public interface ICommandHandler<TContext, TResult>
    {
        Task<TResult> Handle(TContext context);
    }
}

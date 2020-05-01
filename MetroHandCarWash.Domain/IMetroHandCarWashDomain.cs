using MetroHandCarWash.Domain.Domain.Input;
using MetroHandCarWash.Domain.Domain.Result;
using System.Threading.Tasks;

namespace MetroHandCarWash.Domain
{
    public interface IMetroHandCarWashDomain
    {
        Task<RegisterNewClientResult> RegisterNewClient(RegisterNewClientInput newClientInput);
    }
}

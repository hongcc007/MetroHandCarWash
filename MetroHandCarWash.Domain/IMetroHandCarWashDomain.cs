using MetroHandCarWash.Domain.Domain.Input;
using MetroHandCarWash.Domain.Domain.Result;
using System;
using System.Threading.Tasks;

namespace MetroHandCarWash.Domain
{
    public interface IMetroHandCarWashDomain
    {
        Task<RegisterNewClientResult> RegisterNewClient(string lastName,string firstName,string password,string email,string mobile,DateTime creationDate,DateTime modifyDate);
    }
}

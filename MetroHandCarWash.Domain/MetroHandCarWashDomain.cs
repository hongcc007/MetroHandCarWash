using MetroHandCarWash.API.Framework.Command;
using MetroHandCarWash.Domain.Domain.Input;
using MetroHandCarWash.Domain.Domain.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MetroHandCarWash.Domain
{
    public class MetroHandCarWashDomain : IMetroHandCarWashDomain
    {
        private readonly ICommandBus _commandBus;
        public MetroHandCarWashDomain(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task<RegisterNewClientResult> RegisterNewClient(string lastName, string firstName, string password, string email, string mobile, DateTime creationDate, DateTime modifyDate)
        {
            RegisterNewClientInput newClientInput = new RegisterNewClientInput() { LastName = lastName, FirstName = firstName, Password = password, Email = email, Mobile = mobile, CreationDate = creationDate, ModifiedDate = modifyDate };
            return await _commandBus.ExecuteAsync<RegisterNewClientInput, RegisterNewClientResult>(newClientInput);
        }
    }
}

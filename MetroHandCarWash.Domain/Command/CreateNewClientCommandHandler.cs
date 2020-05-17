using MetroHandCarWash.API.Framework.Command;
using MetroHandCarWash.Domain.Context;
using MetroHandCarWash.Domain.Domain.Input;
using MetroHandCarWash.Domain.Domain.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MetroHandCarWash.Domain.Command
{
    public class CreateNewClientCommandHandler : ICommandHandler<RegisterNewClientInput, RegisterNewClientResult>
    {
        private readonly MetroHandCarWashContext _metroHandCarWashContext;
        public CreateNewClientCommandHandler(MetroHandCarWashContext metroHandCarWashContext)
        {
            _metroHandCarWashContext = metroHandCarWashContext;
        }

        public Task<RegisterNewClientResult> Handle(RegisterNewClientInput context)
        {
            //var newBillingAccountNumber = new BillingAccount { CreatedDateTime = DateTime.Now, Ledger = context.Ledger };
            _metroHandCarWashContext.Add<RegisterNewClientInput>(context);
            _metroHandCarWashContext.SaveChanges();

            return null;
        }

        public Task<RegisterNewClientResult> UpdateClient(RegisterNewClientInput context)
        {
            _metroHandCarWashContext.Update<RegisterNewClientInput>(context);
            _metroHandCarWashContext.SaveChanges();
            return null;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Messaging.Broker;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl.SlaveTasks
{
    internal class CustomerLoansTask : Utils.MasterSlave.ISlaveTask<string, object>
    {
        private readonly Messaging.Broker.IAccountInfoBroker _accountInfoBroker;

        public CustomerLoansTask(Messaging.Broker.IAccountInfoBroker accountInfoBroker)
        {
            this._accountInfoBroker = accountInfoBroker;
        }

        public object Run(string parameter)
        {
            var request = new AccountInfoRequest
            {
                CustomerId = parameter,
                Type = AccountInfoRequest.RequestType.Loan,
            };

            return this._accountInfoBroker.GetCustomerLoans(request);
        }
    }
}

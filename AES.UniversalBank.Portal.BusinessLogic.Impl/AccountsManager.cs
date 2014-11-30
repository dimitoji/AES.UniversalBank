using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Portal.BusinessLogic.Models;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl
{
    public class AccountsManager : IAccountsManager
    {
        private readonly Utils.MasterSlave._IMasterStrategy _masterStrategy;
        private readonly Messaging.Broker.IAccountInfoBroker _accountInfoBroker;

        public AccountsManager(
            Utils.MasterSlave._IMasterStrategy masterStrategy,
            Messaging.Broker.IAccountInfoBroker accountInfoBroker)
        {
            this._masterStrategy = masterStrategy;
            this._accountInfoBroker = accountInfoBroker;
        }

        public AccountInfo GetAccountInfo(string userName)
        {
            var requestTypes = (Common.Entities.AccountInfoRequest.RequestType[])Enum.GetValues(typeof (Common.Entities.AccountInfoRequest.RequestType));
            var resultObjects = this._masterStrategy.Process(new BrokerSlaveTask(this._accountInfoBroker, userName), requestTypes);

            var enumerable = resultObjects as object[] ?? resultObjects.ToArray();
            return new AccountInfo
            {
                Customer = enumerable.OfType<Customer>().FirstOrDefault(),
                Accounts = enumerable.OfType<Account>().ToList(),
                Loans = enumerable.OfType<Loan>().ToList(),
                Payments = enumerable.OfType<PaymentInfo>().ToList(),
            };
        }

        class BrokerSlaveTask : Utils.MasterSlave._ISlaveTask<Common.Entities.AccountInfoRequest.RequestType, object>
        {
            private readonly string _userName;
            private readonly Messaging.Broker.IAccountInfoBroker _accountInfoBroker;

            public BrokerSlaveTask(
                Messaging.Broker.IAccountInfoBroker accountInfoBroker,
                string userName)
            {
                this._userName = userName;
                this._accountInfoBroker = accountInfoBroker;
            }

            public object Run(AccountInfoRequest.RequestType type)
            {
                var request = new Common.Entities.AccountInfoRequest
                {
                    CustomerId = _userName,
                    Type = type,
                };

                switch (type)
                {
                    case AccountInfoRequest.RequestType.Customer:
                        return this._accountInfoBroker.GetCustomerProfile(_userName);

                    case AccountInfoRequest.RequestType.Account:
                        return this._accountInfoBroker.GetCustomerAccounts(_userName);

                    case AccountInfoRequest.RequestType.Loan:
                        return this._accountInfoBroker.GetCustomerLoans(_userName);

                    default:
                        return null;
                }
            }
        }
    }
}

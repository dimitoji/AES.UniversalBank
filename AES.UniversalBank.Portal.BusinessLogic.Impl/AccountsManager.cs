using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Common.Trace;
using AES.UniversalBank.Messaging.Broker;
using AES.UniversalBank.Portal.BusinessLogic.Models;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl
{
    public class AccountsManager : IAccountsManager
    {
        private readonly Messaging.Broker.IAccountInfoBroker _accountInfoBroker;

        public AccountsManager(
            Messaging.Broker.IAccountInfoBroker accountInfoBroker)
        {
            this._accountInfoBroker = accountInfoBroker;
        }

        public IList<Account> GetCustomerAccounts(string customerId)
        {
            var request = new AccountInfoRequest
            {
                CustomerId = customerId,
                Type = AccountInfoRequest.RequestType.Account,
            };

            Trace.Write("Obteniendo Cuentas via Broker...");
            return this._accountInfoBroker.GetCustomerAccounts(request);
        }

        public IList<AccountTransaction> GetAccountTransactions(string accountId)
        {
            var request = new AccountInfoRequest
            {
                CustomerId = accountId,
                Type = AccountInfoRequest.RequestType.Transaction,
            };

            Trace.Write("Obteniendo Cuentas via Broker...");
            return this._accountInfoBroker.GetAccountTransactions(request);
        }
    }
}

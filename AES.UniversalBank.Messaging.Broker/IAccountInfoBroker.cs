using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.Messaging.Broker
{
    public interface IAccountInfoBroker
    {
        Common.Entities.Customer GetCustomerProfile(AccountInfoRequest request);
        IList<Common.Entities.Account> GetCustomerAccounts(AccountInfoRequest request);
        IList<Common.Entities.Loan> GetCustomerLoans(AccountInfoRequest request);
        IList<AccountTransaction> GetAccountTransactions(AccountInfoRequest request);
    }
}

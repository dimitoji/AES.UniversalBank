using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.Portal.BusinessLogic
{
    public interface IAccountsManager
    {
        IList<Account> GetCustomerAccounts(string customerId);
        IList<AccountTransaction> GetAccountTransactions(string accountId);
    }
}

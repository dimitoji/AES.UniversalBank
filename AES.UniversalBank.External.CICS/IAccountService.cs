using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.External.CICS
{
    public interface IAccountService
    {
        Common.Entities.Account GetAccount(string id);
        IList<Common.Entities.AccountTransaction> GetAccountTransactions(string id);

        void AddAccountTransaction(string accountId, Common.Entities.AccountTransaction transaction);
    }
}

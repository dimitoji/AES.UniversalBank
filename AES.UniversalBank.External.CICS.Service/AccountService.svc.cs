using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.External.CICS.Service
{
    [ServiceBehavior(Namespace = "http://www.universalbank.com/aes/services")]
    public class AccountService : IAccountService
    {
        public Account GetAccount(string id)
        {
            return new Account
            {
                Id = id,
                Type = "Ahorros",
                BalanceValue = 1500000,
                BalanceDate = DateTime.Today,
            };
        }

        public IList<AccountTransaction> GetAccountTransactions(string id)
        {
            throw new NotImplementedException();
        }

        public void AddAccountTransaction(string accountId, AccountTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}

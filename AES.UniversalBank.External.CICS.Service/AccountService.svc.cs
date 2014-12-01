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
        public IList<Account> GetCustomerAccounts(string customerId)
        {
            return new Account[]
            {
                new Common.Entities.Account
                {
                    Id = "123",
                    Type = "Ahorros",
                    BalanceValue = 5000000,
                    BalanceDate = DateTime.Today,
                },
                new Common.Entities.Account
                {
                    Id = "456",
                    Type = "Corriente",
                    BalanceValue = 2000000,
                    BalanceDate = DateTime.Today,
                },
            }.ToList();
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

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
        public AccountInfo GetAccountInfo(string login)
        {
            return new AccountInfo
            {
                Customer = new Customer
                {
                    Name = "Juan Perez",
                },
                Accounts = new List<Account>
                {
                    new Account
                    {
                        Id = "123",
                        Type = Account.AccountType.Savings,
                        BalanceDate = DateTime.Today,
                        BalanceValue = 0,
                    }
                },
                Payments = new List<PaymentInfo>
                {
                    new PaymentInfo
                    {
                        Id = Guid.NewGuid().ToString(),
                        Description = "",
                    }
                }
            };
        }
    }
}

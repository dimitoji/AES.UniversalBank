using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.Messaging.Broker.Impl
{
    /// <summary>
    /// Esta clase permite simular el comportamiento del BizTalk Broker, solo para efectos de depuracion y pruebas unitarias
    /// </summary>
    public class DebugAccountInfoBroker : IAccountInfoBroker
    {
        public Common.Entities.Customer GetCustomerProfile(AccountInfoRequest request)
        {
            return new Common.Entities.Customer
            {
                Name = "Juan X Perez",
                Email = "juanxperez@mail.com",
                Address = "Carrera con calle",
            };
        }

        public IList<Common.Entities.Account> GetCustomerAccounts(AccountInfoRequest request)
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

        public IList<Common.Entities.Loan> GetCustomerLoans(AccountInfoRequest request)
        {
            return new Loan[]
            {
                new Common.Entities.Loan
                {
                    Id = "ABC01",
                    StartDate = new DateTime(2013, 03, 05),
                    Payoff = 24,
                    PaymentCount = 18,
                    PaymentValue = 5000000,
                    NextPaymentValue = 123000,
                    TotalPaymentValue = 7000000,
                }
            }.ToList();
        }

        public IList<Common.Entities.Payment> GetCustomerPayments(AccountInfoRequest request)
        {
            return new Payment[0].ToList();
        }
    }
}

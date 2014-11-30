using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Messaging.Broker
{
    public interface IAccountInfoBroker
    {
        Common.Entities.Customer GetCustomerProfile(string customerId);
        IList<Common.Entities.Account> GetCustomerAccounts(string customerId);
        IList<Common.Entities.Loan> GetCustomerLoans(string customerId);
        IList<Common.Entities.PaymentInfo> GetCustomerPayments(string customerId);
    }
}

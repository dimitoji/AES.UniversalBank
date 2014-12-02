using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.Portal.BusinessLogic
{
    public interface IPaymentsManager
    {
        IList<Payment> GetCustomerPayments(string customerId);
        Payment GetPayment(string id);
        void SavePayment(Payment payment);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.Payments.BusinessLogic.Impl
{
    [ServiceBehavior(Namespace = "http://www.universalbank.com/aes/services")]
    public class PaymentsService : IPaymentsService
    {
        public IList<Payment> GetCustomerPayments(string customerId)
        {
            return new Payment[0].ToList();
        }

        public void SavePayment(Payment info)
        {
            //TODO: Implement
        }
    }
}

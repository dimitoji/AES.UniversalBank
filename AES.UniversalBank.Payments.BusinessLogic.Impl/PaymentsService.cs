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
            return new []
            {
                new Payment
                {
                    Id = Guid.NewGuid().ToString(),
                    Description = "Test Payment",
                    StartDate = new DateTime(2014, 1, 1),
                    Recurring = true,
                    DayOfMonth = DateTime.Today.Day,
                }   
            }.ToList();
        }

        public Payment GetPayment(string id)
        {
            return new Payment
            {
                Id = Guid.NewGuid().ToString(),
                Description = "Test Payment",
                StartDate = new DateTime(2014, 1, 1),
                Recurring = true,
                DayOfMonth = DateTime.Today.Day,
            };
        }

        public void SavePayment(Payment info)
        {
            //TODO: Implement
        }

        public IList<PaymentRecord> GetPaymentRecords(string id)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Payments.BusinessLogic;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl.ServiceClients
{
    public class PaymentsServiceImpl : IPaymentsService
    {
        public IList<Payment> GetCustomerPayments(string customerId)
        {
            return new PaymentsService.PaymentsServiceClient().GetCustomerPayments(customerId);
        }

        public Payment GetPayment(string id)
        {
            return new PaymentsService.PaymentsServiceClient().GetPayment(id);
        }

        public void SavePayment(Payment payment)
        {
            new PaymentsService.PaymentsServiceClient().SavePayment(payment);
        }

        public IList<PaymentRecord> GetPaymentRecords(string id)
        {
            return new PaymentsService.PaymentsServiceClient().GetPaymentRecords(id);
        }
    }
}
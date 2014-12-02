using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Portal.BusinessLogic.Models;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl
{
    public class PaymentsManager : IPaymentsManager
    {
        private readonly Payments.BusinessLogic.IPaymentsService _paymentService;

        public PaymentsManager(
            Payments.BusinessLogic.IPaymentsService paymentService)
        {
            this._paymentService = paymentService;
        }

        public IList<Payment> GetCustomerPayments(string customerId)
        {
            return this._paymentService.GetCustomerPayments(customerId);
        }

        public Payment GetPayment(string id)
        {
            return this._paymentService.GetPayment(id);
        }

        public void SavePayment(Payment payment)
        {
            this._paymentService.SavePayment(payment);
        }
    }
}

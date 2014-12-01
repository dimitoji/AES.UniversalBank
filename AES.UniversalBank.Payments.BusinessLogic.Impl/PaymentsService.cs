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
        public IList<Payment> GetCutomerPaymentInfos(string customerId)
        {
            return new Payment[0].ToList();
        }

        public void SavePaymentInfo(Payment info)
        {
            //TODO: Implement
        }
    }
}

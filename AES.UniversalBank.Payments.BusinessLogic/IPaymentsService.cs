using System.Collections.Generic;
using System.ServiceModel;

namespace AES.UniversalBank.Payments.BusinessLogic
{
    [ServiceContract(Namespace = "http://www.universalbank.com/aes/services")]
    public interface IPaymentsService
    {
        [OperationContract]
        IList<Common.Entities.Payment> GetCustomerPayments(string customerId);

        [OperationContract]
        Common.Entities.Payment GetPayment(string id);

        [OperationContract]
        void SavePayment(Common.Entities.Payment payment);

        [OperationContract]
        IList<Common.Entities.PaymentRecord> GetPaymentRecords(string id);
    }
}

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
        void SavePayment(Common.Entities.Payment info);
    }
}

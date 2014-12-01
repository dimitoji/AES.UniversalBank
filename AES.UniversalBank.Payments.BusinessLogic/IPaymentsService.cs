using System.Collections.Generic;
using System.ServiceModel;

namespace AES.UniversalBank.Payments.BusinessLogic
{
    [ServiceContract(Namespace = "http://www.universalbank.com/aes/services")]
    public interface IPaymentsService
    {
        [OperationContract]
        IList<Common.Entities.Payment> GetCutomerPaymentInfos(string customerId);

        [OperationContract]
        void SavePaymentInfo(Common.Entities.Payment info);
    }
}

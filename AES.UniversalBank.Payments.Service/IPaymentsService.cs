using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Payments.Service
{
    public interface IPaymentsService
    {
        IList<Common.Entities.Payment> GetCutomerPaymentInfos(string customerId);
        void SavePaymentInfo(Common.Entities.Payment info);
    }
}

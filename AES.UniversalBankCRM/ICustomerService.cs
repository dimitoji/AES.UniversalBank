using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBankCRM
{
    [ServiceContract(Namespace = "http://www.universalbankcrm.com")]
    public interface ICustomerService
    {
        [OperationContract]
        Customer FindCustomerByEmail(string email);
    }
}

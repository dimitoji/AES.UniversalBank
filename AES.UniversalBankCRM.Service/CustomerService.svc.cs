using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AES.UniversalBankCRM.Service
{
    [ServiceBehavior(Namespace = "http://www.universalbankcrm.com")]
    public class CustomerService : ICustomerService
    {
        public Customer FindCustomerByEmail(string email)
        {
            return new Customer
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Juan",
                LastName = "Perez",
                Email = email,
                Address = "Carrera con calle",
            };
        }
    }
}

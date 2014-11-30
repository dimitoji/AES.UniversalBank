using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Entities
{
    public class AccountInfoRequest
    {
        public string CustomerId { get; set; }
        public RequestType Type { get; set; }

        public enum RequestType
        {
            Account,
            Customer,
            Loan,
        }
    }
}

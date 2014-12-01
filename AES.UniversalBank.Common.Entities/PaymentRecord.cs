using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Entities
{
    public class PaymentRecord
    {
        public string Id { get; set; }
        public DateTime ProcessDate { get; set; }
        public string Status { get; set; }
        public string PaymentId { get; set; }
    }
}

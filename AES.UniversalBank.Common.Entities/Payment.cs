using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Entities
{
    public class Payment
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public bool Recurring { get; set; }
        public DateTime StartDate { get; set; }
        public int DayOfMonth { get; set; }
        
        public string PayeeId { get; set; }
        public string PayeeType { get; set; }
        public string PayeeReference { get; set; }
        public decimal Amount { get; set; }
    }
}

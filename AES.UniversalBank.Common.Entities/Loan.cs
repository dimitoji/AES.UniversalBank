using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Entities
{
    public class Loan
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public int Payoff { get; set; }
        public int PaymentCount { get; set; }
        public decimal PaymentValue { get; set; }
        public decimal? NextPaymentValue { get; set; }
        public decimal? TotalPaymentValue { get; set; }
    }
}

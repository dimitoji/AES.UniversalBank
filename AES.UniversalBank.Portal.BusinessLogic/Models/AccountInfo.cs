using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.Portal.BusinessLogic.Models
{
    public class AccountInfo
    {
        public Common.Entities.Customer Customer { get; set; }
        public IList<Common.Entities.Account> Accounts { get; set; }
        public IList<Common.Entities.PaymentInfo> Payments { get; set; }
        public IList<Common.Entities.Loan> Loans { get; set; }

        public AccountInfo()
        {
            this.Accounts = new List<Account>();
            this.Payments = new List<PaymentInfo>();
            this.Loans = new List<Loan>();
        }
    }
}

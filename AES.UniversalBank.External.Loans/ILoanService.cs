using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.External.Loans
{
    public interface ILoanService
    {
        IList<Common.Entities.Loan> GetCustomerLoans(string customerId);
    }
}

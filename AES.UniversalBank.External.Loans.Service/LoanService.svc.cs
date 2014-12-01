using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.External.Loans.Service
{
    public class LoanService : ILoanService
    {
        public IList<Loan> GetCustomerLoans(string customerId)
        {
            return new Loan[]
            {
                new Common.Entities.Loan
                {
                    Id = "ABC01",
                    StartDate = new DateTime(2013, 03, 05),
                    Payoff = 24,
                    PaymentCount = 18,
                    PaymentValue = 5000000,
                    NextPaymentValue = 123000,
                    TotalPaymentValue = 7000000,
                }
            }.ToList();
        }
    }
}

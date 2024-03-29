﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.External.Loans
{
    [ServiceContract]
    public interface ILoanService
    {
        [OperationContract]
        IList<Common.Entities.Loan> GetCustomerLoans(string customerId);
    }
}

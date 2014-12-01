using System.Collections.Generic;
using System.ServiceModel;
using AES.UniversalBank.Common.Entities;

namespace AES.UniversalBank.External.CICS
{
    [ServiceContract(Namespace = "http://www.universalbank.com/aes/services")]
    public interface IAccountService
    {
        [OperationContract]
        IList<Common.Entities.Account> GetCustomerAccounts(string customerId);

        [OperationContract]
        IList<Common.Entities.AccountTransaction> GetAccountTransactions(string id);

        [OperationContract]
        void AddAccountTransaction(string accountId, Common.Entities.AccountTransaction transaction);
    }
}

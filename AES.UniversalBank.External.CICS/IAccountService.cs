using System.Collections.Generic;
using System.ServiceModel;

namespace AES.UniversalBank.External.CICS
{
    [ServiceContract(Namespace = "http://www.universalbank.com/aes/services")]
    public interface IAccountService
    {
        [OperationContract]
        Common.Entities.Account GetAccount(string id);

        [OperationContract]
        IList<Common.Entities.AccountTransaction> GetAccountTransactions(string id);

        [OperationContract]
        void AddAccountTransaction(string accountId, Common.Entities.AccountTransaction transaction);
    }
}

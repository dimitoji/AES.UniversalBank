using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Messaging.Broker.Impl
{
    public class BizTalkAccountInfoBroker : IAccountInfoBroker
    {
        public Common.Entities.Customer GetCustomerProfile(AccountInfoRequest request)
        {
            try
            {
                var client = new BizTalkServiceReference.AccountInfoBrokerClient();

                // Invokes the biztalk service
                var customer = client.GetCustomerProfile(
                    new BizTalkServiceReference.AccountInfoRequest
                    {
                        CustomerId = request.CustomerId,
                        Type = request.Type.ToString(),
                    });

                return new Common.Entities.Customer
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    Address = customer.Address,
                };
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<Common.Entities.Account> GetCustomerAccounts(AccountInfoRequest request)
        {
            try
            {
                var client = new BizTalkServiceReference.AccountInfoBrokerClient();

                // Invokes the biztalk service
                var accounts = client.GetCustomerAccounts(
                    new BizTalkServiceReference.AccountInfoRequest
                    {
                        CustomerId = request.CustomerId,
                        Type = request.Type.ToString(),
                    });

                return accounts.Select(
                    a => new Common.Entities.Account
                    {
                        Id = a.Id,
                        Type = a.Type,
                        BalanceValue = a.BalanceValue,
                        BalanceDate = a.BalanceDate,
                    }
                ).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<Common.Entities.Loan> GetCustomerLoans(AccountInfoRequest request)
        {
            throw new NotImplementedException();
        }

        public IList<Common.Entities.Payment> GetCustomerPayments(AccountInfoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

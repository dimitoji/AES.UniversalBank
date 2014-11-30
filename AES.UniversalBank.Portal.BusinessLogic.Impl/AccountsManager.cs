using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Messaging.Broker;
using AES.UniversalBank.Portal.BusinessLogic.Models;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl
{
    public class AccountsManager : IAccountsManager
    {
        private readonly Utils.MasterSlave.IMasterSlaveStrategy _masterSlaveStrategy;
        private readonly Messaging.Broker.IAccountInfoBroker _accountInfoBroker;

        public AccountsManager(
            Utils.MasterSlave.IMasterSlaveStrategy masterSlaveStrategy,
            Messaging.Broker.IAccountInfoBroker accountInfoBroker)
        {
            this._masterSlaveStrategy = masterSlaveStrategy;
            this._accountInfoBroker = accountInfoBroker;
        }

        public AccountInfo GetAccountInfo(string userName)
        {
            // Genera el listado de tareas secundarias a ejecutar
            var tasks = new Utils.MasterSlave.ISlaveTask<string, object>[]
            {
                new SlaveTasks.CustomerProfileTask(this._accountInfoBroker),
                new SlaveTasks.CustomerLoansTask(this._accountInfoBroker),
                new SlaveTasks.CustomerAccountsTask(this._accountInfoBroker),
                new SlaveTasks.CustomerPaymentsTask(this._accountInfoBroker),
            };

            // Procesa las tareas segun la estrategia de Master/Slave
            var resultObjects = this._masterSlaveStrategy.Process(tasks, userName);

            // Genera la entidad completa agregando los valores recuperados
            var enumerable = resultObjects as object[] ??
                resultObjects
                .SelectMany(o => o is IEnumerable<object> ? ((IEnumerable<object>)o).ToArray() : new []{ o })
                .ToArray();
            return new AccountInfo
            {
                Customer = enumerable.OfType<Customer>().FirstOrDefault(),
                Accounts = enumerable.OfType<Account>().ToList(),
                Loans = enumerable.OfType<Loan>().ToList(),
                Payments = enumerable.OfType<Payment>().ToList(),
            };
        }
    }
}

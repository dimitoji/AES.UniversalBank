using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES.UniversalBank.Common.Entities;
using AES.UniversalBank.Common.Trace;

namespace AES.UniversalBank.Portal.BusinessLogic.Impl.SlaveTasks
{
    internal class CustomerPaymentsTask : Utils.MasterSlave.ISlaveTask<string, object>
    {
        private readonly Payments.BusinessLogic.IPaymentsService _paymentService;

        public CustomerPaymentsTask(Payments.BusinessLogic.IPaymentsService paymentService)
        {
            this._paymentService = paymentService;
        }

        public object Run(string parameter)
        {
            Trace.Write("Obteniendo Pagos via Servicio...");
            return this._paymentService.GetCustomerPayments(parameter);
        }
    }
}

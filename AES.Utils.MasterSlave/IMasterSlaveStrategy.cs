using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Utils.MasterSlave
{
    public interface IMasterSlaveStrategy
    {
        IEnumerable<TOut> Process<TIn, TOut>(ISlaveTask<TIn, TOut> slaveTask, IEnumerable<TIn> data);
        IEnumerable<TOut> Process<TIn, TOut>(IEnumerable<ISlaveTask<TIn, TOut>> slaveTasks, TIn data);
    }
}

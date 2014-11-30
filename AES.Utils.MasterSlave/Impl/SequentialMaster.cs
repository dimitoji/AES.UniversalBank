using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Utils.MasterSlave.Impl
{
    public class SequentialMasterSlave : IMasterSlaveStrategy
    {
        public IEnumerable<TOut> Process<TIn, TOut>(ISlaveTask<TIn, TOut> slave, IEnumerable<TIn> data)
        {
            return data.Select(d => slave != null ? slave.Run(d) : default(TOut));
        }

        public IEnumerable<TOut> Process<TIn, TOut>(IEnumerable<ISlaveTask<TIn, TOut>> slaveTasks, TIn data)
        {
            return slaveTasks.Select(t => t.Run((data)));
        }
    }
}

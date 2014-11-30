using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Utils.MasterSlave.Impl
{
    public class SequentialMaster : _IMasterStrategy
    {
        public IEnumerable<TOut> Process<TIn, TOut>(_ISlaveTask<TIn, TOut> slave, IEnumerable<TIn> data)
        {
            return data.Select(d => slave != null ? slave.Run(d) : default(TOut));
        }
    }
}

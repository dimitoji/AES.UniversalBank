using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Utils.MasterSlave
{
    public interface _IMasterStrategy
    {
        IEnumerable<TOut> Process<TIn, TOut>(_ISlaveTask<TIn, TOut> slave, IEnumerable<TIn> data);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Utils.MasterSlave
{
    public interface _ISlaveTask<TIn, TOut>
    {
        TOut Run(TIn parameter);
    }
}

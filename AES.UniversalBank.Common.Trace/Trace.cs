using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.UniversalBank.Common.Trace
{
    public static class Trace
    {
        public static void Write(string message)
        {
            var frame = new StackFrame(1);
            var method = frame.GetMethod();
            var @class = method.DeclaringType;

            System.Diagnostics.Trace.WriteLine(string.Format("{0}.{1} >> {2}", @class.FullName, method.Name, message));
        }
    }
}

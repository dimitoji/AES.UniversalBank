using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Utils.MasterSlave.Impl
{
    public class ParallelMasterSlave : IMasterSlaveStrategy
    {
        public IEnumerable<TOut> Process<TIn, TOut>(ISlaveTask<TIn, TOut> slave, IEnumerable<TIn> data)
        {
            var results = new List<TOut>();
            var sync = new object();

            // CReate a new thread for every item
            var taskList = data.Select(
                d => new System.Threading.Thread(
                    () =>
                    {
                        var output = slave.Run(d);
                        lock (sync)
                        {
                            results.Add(output);
                        }
                    })
                )
                .ToList();

            // Start threads
            foreach (var task in taskList)
                task.Start();

            System.Threading.Thread.Sleep(100);

            // Join Threads
            foreach (var task in taskList)
                task.Join();

            return results;
        }

        public IEnumerable<TOut> Process<TIn, TOut>(IEnumerable<ISlaveTask<TIn, TOut>> slaveTasks, TIn data)
        {
            var results = new List<TOut>();
            var sync = new object();

            // CReate a new thread for every item
            var taskList = slaveTasks.Select(
                t => new System.Threading.Thread(
                    () =>
                    {
                        var output = t.Run(data);
                        lock (sync)
                        {
                            results.Add(output);
                        }
                    })
                )
                .ToList();

            // Start threads
            foreach (var task in taskList)
                task.Start();

            System.Threading.Thread.Sleep(100);

            // Join Threads
            foreach (var task in taskList)
                task.Join();

            return results;
        }
    }
}

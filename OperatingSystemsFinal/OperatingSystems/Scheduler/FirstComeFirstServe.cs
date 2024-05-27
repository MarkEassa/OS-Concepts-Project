using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystems.Scheduler
{
    public sealed class FirstComeFirstServe : Scheduler
    {
        public override IEnumerable<(Process, int, int)> Run(List<Process> processes)
        {
            int time = 0;
            var worklist = new Queue<Process>(processes.OrderBy((proc) => proc.ArrivalTime).ThenBy(proc => proc.Name));

            while (worklist.Count > 0)
            {
                var process = worklist.Dequeue();
                time = Math.Max(time, process.ArrivalTime);
                yield return (process, time, time + process.BurstTime);
                time += process.BurstTime;
            }
        }
    }
}

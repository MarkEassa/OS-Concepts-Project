using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatingSystems.Scheduler
{
    public sealed class RoundRobin : Scheduler
    {
        private int Quantum;

        public RoundRobin(int quantum)
        {
            Quantum = quantum;
        }

        public override IEnumerable<(Process, int, int)> Run(List<Process> inputProcesses)
        {
            var procs = inputProcesses
                .Select(proc => proc.Clone())
                .OrderBy(proc => proc.ArrivalTime)
                .ThenBy(proc => proc.Name)
                .ToList();

            var completed = new HashSet<string>();

            int time = procs
                .Select(proc => proc.ArrivalTime)
                .Min();

            while (true)
            {
                bool done = true;

                foreach (var proc in procs)
                {
                    if (proc.BurstTime > 0)
                    {
                        done = false;
                        if (proc.BurstTime > Quantum)
                        {
                            yield return (proc, time, time + Quantum);
                            time += Quantum;
                            proc.BurstTime -= Quantum;
                        }
                        else
                        {
                            yield return (proc, time, time + proc.BurstTime);
                            time += proc.BurstTime;
                            proc.BurstTime = 0;
                        }
                    }
                }

                if (done) yield break;
            }
        }
    }
}

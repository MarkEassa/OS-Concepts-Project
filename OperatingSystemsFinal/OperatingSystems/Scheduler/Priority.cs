using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystems.Scheduler
{
    public sealed class Priority : Scheduler
    {
        public bool Preemptive;
        public bool LowerPriorityFirst;
        public Priority(bool preemptive = false, bool lowerPriorityFirst = true)
        {
            this.Preemptive = preemptive;
            this.LowerPriorityFirst = lowerPriorityFirst;
        }

        public override IEnumerable<(Process, int, int)> Run(List<Process> inputProcesses)
        {
            var processes = inputProcesses.Select(proc => proc.Clone()).ToList();

            if (!LowerPriorityFirst)
            {
                processes = processes.Select(
                    proc => new Process(proc, priority: int.MaxValue - proc.Priority)
                ).ToList();
            }

            if (Preemptive)
            {
                Process prev = null;
                int startTime = 0;
                int finishTime = 0;
                foreach (var (proc, start, finish) in RunPreemptively(processes))
                {
                    if (prev == null)
                    {
                        prev = proc;
                        startTime = start;
                        finishTime = finish;
                        continue;
                    }

                    if (proc.Name == prev.Name)
                    {
                        finishTime = finish;
                        continue;
                    }

                    yield return (prev, startTime, finishTime);
                    prev = proc;
                    startTime = start;
                    finishTime = finish;
                }
                if (prev != null)
                    yield return (prev, startTime, finishTime);
            }
            else
            {
                foreach (var interval in RunNonPreemptively(processes))
                    yield return interval;
            }
        }

        private IEnumerable<(Process, int, int)> RunPreemptively(List<Process> proc)
        {
            int n = proc.Count;
            int[] remainingBurstTime = new int[n];

            // Copy the burst time into rt[]
            for (int i = 0; i < n; i++)
                remainingBurstTime[i] = proc[i].BurstTime;

            int complete = 0, t = 0, minm = int.MaxValue;
            int highestPriority = 0;
            bool check = false;

            // Process until all processes gets
            // completed
            while (complete != n)
            {

                // Find process with minimum
                // remaining time among the
                // processes that arrives till the
                // current time`
                for (int j = 0; j < n; j++)
                {
                    if ((proc[j].ArrivalTime <= t) &&
                    (proc[j].Priority < minm) && remainingBurstTime[j] > 0)
                    {
                        minm = proc[j].Priority;
                        highestPriority = j;
                        check = true;
                    }
                }

                if (!check)
                {
                    t++;
                    continue;
                }

                // Reduce remaining time by one
                yield return (proc[highestPriority], t, t + 1);
                remainingBurstTime[highestPriority]--;

                // Update minimum
                minm = remainingBurstTime[highestPriority];
                if (minm == 0)
                    minm = int.MaxValue;

                // If a process gets completely
                // executed
                if (remainingBurstTime[highestPriority] == 0)
                {

                    // Increment complete
                    complete++;
                    check = false;

                    // Calculate waiting time
                }
                // Increment time
                t++;
            }
        }

        private IEnumerable<(Process, int, int)> RunNonPreemptively(List<Process> processes)
        {
            int time = 0;
            var worklist = new Queue<Process>(
                processes
                .OrderBy(proc => proc.ArrivalTime)
                .ThenBy(proc => proc.Priority)
                .ThenBy(proc => proc.Name)
            );

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

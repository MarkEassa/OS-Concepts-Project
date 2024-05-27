using System;
using System.Collections.Generic;

namespace OperatingSystems.Scheduler
{
    public abstract class Scheduler
    {
        public abstract IEnumerable<(Process, int, int)> Run(List<Process> processes);

        public Dictionary<string, (int turnaround, int waiting, int response)> Profile(List<Process> processes)
        {
            var turnaround = new Dictionary<string, int>();
            var responses = new Dictionary<string, int>();
            var waiting = new Dictionary<string, int>();
            var lastFinished = new Dictionary<string, int>();

            foreach (var (proc, start, finish) in Run(processes))
            {
                int turnaroundTime = finish - proc.ArrivalTime;
                
                if (!waiting.ContainsKey(proc.Name))
                {
                    waiting[proc.Name] = start - proc.ArrivalTime;
                }
                else
                {
                    waiting[proc.Name] += start - lastFinished[proc.Name];
                }

                if (!responses.ContainsKey(proc.Name))
                {
                    responses[proc.Name] = start - proc.ArrivalTime;
                }

                lastFinished[proc.Name] = finish;
                turnaround[proc.Name] = turnaroundTime;
            }

            var result = new Dictionary<string, (int, int, int)>();

            foreach (var proc in turnaround.Keys)
            {
                var waitingTime = waiting[proc];
                var responseTime = responses[proc];
                var turnaroundTime = turnaround[proc];
                result[proc] = (turnaroundTime, waitingTime, responseTime);
            }

            return result;
        }

        public static (double turnaround, double waiting, double response) AveragesFromProfile(Dictionary<string, (int, int, int)> profile)
        {
            double waitingSum = 0.0d;
            double responseSum = 0.0d;
            int length = profile.Count;
            double turnaroundSum = 0.0d;

            foreach (var (turnaround, waiting, responseTime) in profile.Values)
            {
                waitingSum += waiting;
                turnaroundSum += turnaround;
                responseSum += responseTime;
            }

            return (
                turnaroundSum / length, 
                waitingSum / length,
                responseSum / length
            );
        }

        public void Debug(List<Process> processes)
        {
            Console.WriteLine("Name\tFrom\tTo\tTurnaround\tWaiting");
            var profile = Profile(processes);

            foreach (var (proc, from, to) in Run(processes))
            {
                var (t, w, r) = profile[proc.Name];
                Console.WriteLine($"{proc.Name}\t\t{from}\t\t{to}\t\t{t}\t\t{w}");
            }

            var (turnaround, waiting, response) = AveragesFromProfile(Profile(processes));
            Console.WriteLine($"Average Turnaround Time: {turnaround}");
            Console.WriteLine($"Average Waiting Time:    {waiting}");
            Console.WriteLine($"Average Response Time:   {response}");
        }
    }
}

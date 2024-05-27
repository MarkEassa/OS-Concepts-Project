using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystems.Scheduler
{
    public sealed class Process
    {
        public string Name;
        public int Priority;
        public int BurstTime;
        public int ArrivalTime;

        public Process(string name, int burstTime, int priority = int.MaxValue, int arrivalTime = 0)
        {
            Name = name;
            Priority = priority;
            BurstTime = burstTime;
            ArrivalTime = arrivalTime;
        }

        public Process(Process that, string name = null, int? priority = null, int? burstTime = null, int? arrivalTime = null)
        {
            Name = name == null ? that.Name : name;
            Priority = priority == null ? that.Priority : (int)priority;
            BurstTime = burstTime == null ? that.BurstTime : (int)burstTime;
            ArrivalTime = arrivalTime == null ? that.ArrivalTime : (int)arrivalTime;
        }

        public Process Clone()
        {
            return new Process(
                name: Name,
                priority: Priority,
                burstTime: BurstTime,
                arrivalTime: ArrivalTime
            );
        }

        public override string ToString()
        {
            return $"Process(Name={Name}, Priority={Priority}, BurstTime={BurstTime}, ArrivalTime={ArrivalTime})";
            //return Name;
        }
    }
}

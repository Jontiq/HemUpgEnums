using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemUpgEnums
{
    internal class Task
    {
        //enums
        public enum Colors
        {
            green,
            yellow,
            red,
        }

        public enum Priorities
        {
            low,
            medium,
            high,
        }
        //props
        public Colors Color { get; set; }
        public Priorities Priority { get; set; }
        //constructor
        public Task(Colors color, Priorities priority)
        {
            Color = color;
            Priority = priority;
        }
        //methods
        public void GetTaskInfo()
        {
            Console.WriteLine($"Task Color: {Color}, Task Priority: {Priority}");
        }
    }
}

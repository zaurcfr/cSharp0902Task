using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    class Worker : Human, IWorker
    {
        public string Position { get ; set ; }
        public int Salary { get ; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        //operations[]
        //addOperation();

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}

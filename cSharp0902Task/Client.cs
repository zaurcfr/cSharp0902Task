using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    class Client : Human
    {
        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }
        public int Salary { get; set; }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Address: {LiveAddress}");
            Console.WriteLine($"Work Address: {WorkAddress}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}

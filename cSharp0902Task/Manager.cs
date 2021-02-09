using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    class Manager : Human,IWorker, IOrganize
    {
        public string Position { get; set ; }
        public int Salary { get ; set; }

        public void Organize()
        {
            Console.WriteLine("Manager Organize");
        }
        public void CalculateSalaries()
        {

        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}

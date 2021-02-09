using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    class CEO : Human,IWorker,IManage,IOrganize
    {
        public int Salary { get ; set ; }
        public string Position { get ; set ; }

        public void Control()
        {
            Console.WriteLine("Control");
        }
        public void MakeMeeting()
        {
            Console.WriteLine("Make meeting");
        }
        public void Organize()
        {
            Console.WriteLine("Organize");
        }

        public void DecreasePercentage(int percent)
        {
            
        }

    }
}

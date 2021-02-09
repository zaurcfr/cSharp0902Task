using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    abstract class Human : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {guid}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}

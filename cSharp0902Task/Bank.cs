using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    class Bank
    {
        public string Name { get; set; }
        public double Budget { get; set; }
        public double Profit { get; set; }
        public CEO Ceo { get; set; }
        public Worker[] Workers { get; set; }
        public Manager[] Managers { get; set; }
        public Client[] Clients { get; set; }

        //public void CalculateProfit() { }
        //public void ShowClientCredit(string fullname) { }
        //public void PayCredit(Client, money) { }
        //public void ShowAllCredit() { }
    }
}

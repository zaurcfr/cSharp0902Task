using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    class Credit
    {
        public Client client { get; set; }
        public int Amount { get; set; }
        public int Percent { get; set; } = 20;
        public int Months { get; set; } = 20;
        public double Payment { get; set; }
        public double PaymentPerMonth { get; set; }
        public void CalculatePayment()
        {
            Payment = (Amount * (100 + Percent) / 100);
        }
        public void CalculatePaymentPerMonth()
        {
            PaymentPerMonth = (Amount * (100 + Percent) / 100) / 12;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment
    {
        public void monthlypayment(double p, double y, double R)
        {
            double n = 12 * y;
            double r = R / (12 * 100);
            double payment = p * r / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine(payment + "is monthly payment");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        int number, sum = 0, n;
        public void Perfect()
        {
            Console.WriteLine("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}

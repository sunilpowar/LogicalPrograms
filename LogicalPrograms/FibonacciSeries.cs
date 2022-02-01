using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        int first = 0, second = 1, third = 0;
        public void Fibo()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(first);
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(first);
                }
                else if (i == 1)
                {
                    Console.WriteLine(second);
                }
                else if (i > 1)
                {
                    third = first + second;
                    first = second;
                    second = third;
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(" exit");
                }


            }
        }
    }
}

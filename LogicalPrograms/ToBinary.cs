using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ToBinary
    {
        public static int[] binary = new int[8];

        public static void ConvertToBinary()
        {

            Console.WriteLine("Enter a decimal number to convert to binary: ");
            int decimalNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; decimalNum > 0; i++)
            {
                binary[i] = decimalNum % 2;
                decimalNum /= 2;
            }
            Console.WriteLine("binary number is: ");
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i] + " ");
            }
        }
    }
}

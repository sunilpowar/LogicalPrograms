using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SwapNibbles
    {
        public static int[] temp = new int[8];
        public static int[] temp2 = new int[8];
        public static int newDecNum = 0;
        public static void Swap_GetResultantNumber()
        {
            ToBinary.ConvertToBinary();
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                temp[7 - i] = ToBinary.binary[i];
            }

            Console.WriteLine("\nFirst nibble being stored in second nibble");
            for (int i = 4; i < 8; i++)
            {
                temp2[i] = temp[i - 4];
                Console.Write(temp[i - 4] + " ");
            }
            Console.WriteLine("\nSecond nibble being stored in first nibble");
            for (int i = 0; i < 4; i++)
            {
                temp2[i] = temp[i + 4];
                Console.Write(temp[i + 4] + " ");
            }
            Console.WriteLine("\nSwapped Nibble of binary number:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(temp2[i] + " ");
            }

            Console.WriteLine("\n Binary to decimal conversion");
            int n = 0;
            for (int i = 7; i >= 0; i--)
            {
                newDecNum = newDecNum + (int)(temp2[i] * Math.Pow(2, n));
                n++;
            }
            Console.WriteLine("Resultant Decimal number after swapping nibbles is: " + newDecNum);
        }
    }
}

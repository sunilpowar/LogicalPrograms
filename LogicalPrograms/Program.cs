using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Logical problems");
            Console.WriteLine("Enter Progran number to get excuted \n1. Fibonacci series \n2. PerfectNumbers " +
                "\n3.PrimeNumber \n4.ReverseNumber \n5.TemperatureConversion \n6.MonthlyPayment\n7.VendingMachine" +
                "\n8.StopWatch \n9.DayOfTheweek \n10.BinaryConnertion \n11.SwapNibbles \n12.SquareRoot \n13.couponNumbers" +
                " \n14.Exit ");
            int option;
            option = Convert.ToInt32(Console.ReadLine());

            bool flag = true;
            while (flag)
            {

            switch (option)
            {
                case 1:
                    FibonacciSeries Fibonacci = new FibonacciSeries();
                    Fibonacci.Fibo();
                    break;
                case 2:
                    PerfectNumber perfectnum = new PerfectNumber();
                    perfectnum.Perfect();
                    break;
                case 3:
                    Prime_number primenum = new Prime_number();
                    primenum.Prime();
                    break;
                case 4:
                    ReverseNumber reversenum = new ReverseNumber();
                    reversenum.Reverse();
                    break;
                case 5:
                    Temperature_conv temperature = new Temperature_conv();
                    Console.WriteLine("Enter value of temperature ");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    temperature.temperatureconversion(temp);
                    break;
                case 6:
                    Monthly_payment month = new Monthly_payment();
                    Console.WriteLine("Enter the value of principal");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the year");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the rate : ");
                    double R = Convert.ToDouble(Console.ReadLine());
                    month.monthlypayment(p, y, R);
                    break;
                case 7:
                    Console.WriteLine("Enter Amount to get Change");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Vendingmachine vending = new Vendingmachine();
                    vending.Getchange(amount);
                    break;
                case 8:
                    ProgramStopwatch.ElapsedTime();
                    break;
                case 9:
                    DayOf_Week weekday = new DayOf_Week();
                    Console.WriteLine("Enter day");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int Month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    weekday.Day(day, Month, year);
                    break;

                case 10:
                    BinaryConvertion bin = new BinaryConvertion();
                    bin.decimalToBinary();
                    break;
                case 11:
                    SwapNibles obj12 = new SwapNibles();
                    Console.WriteLine("Enter number to convert in Binary :");
                    int number = Convert.ToInt32(Console.ReadLine());
                    obj12.ToBinary(number);
                    break;
                case 12:
                    SquareRoot.Sqrt();
                    break;
                case 13:
                    CouponNumbers couponNumbers = new CouponNumbers();
                    couponNumbers.couponsNumbers();
                    break;
                default:
                    Console.WriteLine("please enter correct");
                    break;
            }
            //}
            Console.ReadLine();
        }
    }
    }
}

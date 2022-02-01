using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public static void ElapsedTime()
        {
            //created Object of Stopwatch class
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Hit Enter to start Watch");
            stopWatch.Start();    //Timmer started.
            Thread.Sleep(6000);  //pause for 6 second
            Console.WriteLine("Hit Enter to stop Watch");

            stopWatch.Stop();   //Timer stopped




            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds);
        }
    }
}

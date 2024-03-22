using System;
using System.Threading;
using System.Diagnostics;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Declaring stopwatches
            /// </summary>
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //Controlling the Stopwatches
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(600);
            crono1.Stop();
            crono2.Stop();

            //Reading time of Stopwatches in seconds
            float t1 = crono1.ElapsedMilliseconds / 1000f;
            float t2 = crono2.ElapsedMilliseconds / 1000f;

            //Print elapsed time
            Console.WriteLine($"{t1:f3}");
            Console.WriteLine($"{t2:f3}");
        }
    }
}

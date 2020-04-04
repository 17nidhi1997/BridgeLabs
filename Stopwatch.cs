using System;
using System.Diagnostics;

namespace Functiona
{
    class swatch
    {
        public void watch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class Harmonic
    {
        public void harnum()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            double i, s = 0.0;
            for (i=1;i<=n;i++)
            {
                s = s + 1 / i;
            }
            Console.WriteLine("The harmonic series is:" + s);
        }
    }
}

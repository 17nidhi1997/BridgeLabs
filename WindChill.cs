using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class windchill
    {
        public void wind()
        {
            Console.WriteLine("Enter the value of temperature in(fahrenheit)");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of speed in(miles)");
            double s = Convert.ToDouble(Console.ReadLine());
            double winds = (35.74 + 0.615 +((0.4275*f) - 35.75)* Math.Pow(s, 0.16));
            Console.WriteLine(winds);

        }
    }
}

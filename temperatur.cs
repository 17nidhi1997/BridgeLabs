using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class temperaturConversion
    {
        public void convert()
        {
            Console.WriteLine("Enter the value in celsius");
            double n = Convert.ToDouble(Console.ReadLine());
            
            Console.Write(Cel_To_Fah(n));

            static double Cel_To_Fah(double n)
            {
                return ((n * 9.0 / 5.0) + 32.0);
            } 
        }

    }
}


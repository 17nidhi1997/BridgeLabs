using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class powerTwo
    {
        public void power()
        {
            Console.WriteLine("Enter the value");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power of :");
            while (value > 0)
            {  
                double num = Math.Pow(value, 2);
                Console.WriteLine(num);
                value--;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Functiona
{
    class quadricEquation
    {
        public void equation()
        {
            Console.WriteLine("Enter the value of a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = (Math.Pow(b, 2) - 4 * a * c);
            Console.WriteLine(delta);
            if(delta > 0)
            {
                double root1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                double root2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("root1:" + root1);
                Console.WriteLine("root2:" + root2);
            }
            else
            {
                Console.WriteLine("imagenary" );
            }
        }
    }
}
